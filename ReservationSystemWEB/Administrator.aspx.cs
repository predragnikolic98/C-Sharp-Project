using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using Newtonsoft.Json;

namespace ReservationSystemWEB
{
    public partial class Administrator : System.Web.UI.Page
    {
        static bool switchCase = false;
        StringBuilder tableAll = new StringBuilder();
        StringBuilder tableSelect = new StringBuilder();
        protected async void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            {

                tableAll.Append("<table border = '1'>");
                tableAll.Append("<tr><th> Číslo sedadla </th>" +
                             "<th> Jméno </th>" +
                             "<th> Příjmení </th>" +
                             "<th> Email </th>" +
                             "<th> Telefon </th>");
                tableAll.Append("</tr>");

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44350/");
                HttpResponseMessage response = client.GetAsync("api/values").Result;
                if (response.IsSuccessStatusCode)
                {
                    var reservation = await response.Content.ReadAsStringAsync();
                    var EmpInfo = JsonConvert.DeserializeObject<IEnumerable<Reservations>>(reservation);
                    foreach (var entry in EmpInfo)
                    {
                        tableAll.Append("<tr'>");
                        tableAll.Append("<td>" + entry.Id + "</td>");
                        tableAll.Append("<td>" + entry.Name + "</td>");
                        tableAll.Append("<td>" + entry.Surname + "</td>");
                        tableAll.Append("<td>" + entry.Email + "</td>");
                        tableAll.Append("<td>" + entry.MobileNumber + "</td>");
                        tableAll.Append("</tr>");
                    }
                }

                tableAll.Append("</table");
                PlaceHolder1.Controls.Add(new Literal { Text = tableAll.ToString() });
            }
        }


        protected async void Button1_Click(object sender, EventArgs e)
        {
            Session["MessageCurrent"] ="";
            if (txtEmailGet.Text != string.Empty)
            {
               
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44350/");
                HttpResponseMessage response = client.GetAsync("api/values?email="+txtEmailGet.Text + "").Result;
                if (response.IsSuccessStatusCode)
                {
                    var reservation = await response.Content.ReadAsStringAsync();
                    if (reservation != "[]") 
                    {
                        var EmpInfo = JsonConvert.DeserializeObject<IEnumerable<Reservations>>(reservation);

                        tableSelect.Append("<table border = '1'>");
                        tableSelect.Append("<tr><th> Číslo sedadla </th>" +
                                     "<th> Jméno </th>" +
                                     "<th> Příjmení </th>" +
                                     "<th> Email </th>" +
                                     "<th> Telefon </th>");
                        tableSelect.Append("</tr>");

                        foreach (var entry in EmpInfo)
                        {
                            tableSelect.Append("<tr'>");
                            tableSelect.Append("<td>" + entry.Id + "</td>");
                            tableSelect.Append("<td>" + entry.Name + "</td>");
                            tableSelect.Append("<td>" + entry.Surname + "</td>");
                            tableSelect.Append("<td>" + entry.Email + "</td>");
                            tableSelect.Append("<td>" + entry.MobileNumber + "</td>");
                            tableSelect.Append("</tr>");
                        }
                    }
                    else
                        Session["MessageCurrent"] = "Pro tento email nebyla nalezena žádná rezervace.";

                }

                tableSelect.Append("</table");
                PlaceHolder2.Controls.Add(new Literal { Text = tableSelect.ToString() });
            }
            else
            {
                Response.Write("<script>alert('Doplňte prosím email.')</script>");
            }
        }
        protected async void Button2_Click(object sender, EventArgs e)
        {

            if (!switchCase)
            {
                Session["MessageDelete"] = "";
                Session["ChooseSeats"] = "";
                Session["Email"] = txtEmailDelete.Text;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44350/");
                HttpResponseMessage response = client.GetAsync("api/values?email=" + txtEmailDelete.Text + "").Result;
                if (response.IsSuccessStatusCode)
                {

                    var reservation = await response.Content.ReadAsStringAsync();
                    if (reservation != "[]")
                    {
                        var EmpInfo = JsonConvert.DeserializeObject<IEnumerable<Reservations>>(reservation);

                        foreach (var entry in EmpInfo)
                        {
                            chklst.Items.Add(entry.Id.ToString());
                        }
                        Button2.Text = "Potvrdit";
                        switchCase = true;
                        Session["ChooseSeats"] = "Vyberte sedadla u kterých chcete smazat rezervaci:";

                    }
                    else
                        Session["MessageDelete"] = "Pro tento email nebyla nalezena žádná rezervace.";

                }
            }
            else
            {
                Session["ChooseSeats"] = "";
                if (chklst.SelectedItem != null)
                {
                    foreach (ListItem hob in chklst.Items)
                    {
                        if (hob.Selected == true)
                        {
                            Session["Email"] = txtEmailDelete.Text;
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri("https://localhost:44350/");
                            HttpResponseMessage response = client.DeleteAsync("api/values/5?email=" + txtEmailDelete.Text + "&id=" + Convert.ToInt32(hob.Text) + "").Result;
                            if (response.IsSuccessStatusCode)
                            {
                                Session["MessageDelete"] = "Rezervace byla úspěšně zrušena";
                            }
                            //chklst.Items.Remove(hob.Text);
                        }
                    }

                    chklst.Items.Clear();

                    switchCase = false;
                    Button2.Text = "Dále";
                }
                else
                {
                    Session["MessageDelete"] = "Zrušení rezervace neproběhlo, protože jste nevybrali žádné sedalo, " +
                        "které chcete zrušit";
                    chklst.Items.Clear();

                    switchCase = false;
                    Button2.Text = "Dále";
                }
            }
        }

    }
}