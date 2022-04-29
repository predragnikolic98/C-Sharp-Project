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
 
        StringBuilder table = new StringBuilder();
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                table.Append("<table border = '1'>");
                table.Append("<tr><th> Číslo sedadla </th>" +
                             "<th> Jméno </th>" +
                             "<th> Příjmení </th>" +
                             "<th> Email </th>" +
                             "<th> Telefon </th>");
                table.Append("</tr>");

                Reservations dt = new Reservations();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44350/");
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = client.GetAsync("api/values").Result;
                if (response.IsSuccessStatusCode)
                {
                    var reservation = await response.Content.ReadAsStringAsync();
                    var EmpInfo = JsonConvert.DeserializeObject<IEnumerable<Reservations>>(reservation);
                    foreach (var entry in EmpInfo)
                    {
                        table.Append("<tr'>");
                        table.Append("<td>" + entry.Id + "</td>");
                        table.Append("<td>" + entry.Name + "</td>");
                        table.Append("<td>" + entry.Surname + "</td>");
                        table.Append("<td>" + entry.Email + "</td>");
                        table.Append("<td>" + entry.MobileNumber + "</td>");
                        table.Append("</tr>");
                    }
                }

                table.Append("</table");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

            }


    }


        protected async void Button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {

                table.Append("<table border = '1'>");
                table.Append("<tr><th> Číslo sedadla </th>" +
                             "<th> Jméno </th>" +
                             "<th> Příjmení </th>" +
                             "<th> Email </th>" +
                             "<th> Telefon </th>");
                table.Append("</tr>");

                Reservations dt = new Reservations();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44350/");
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = client.GetAsync("api/values?email="+txtEmail.Text + "").Result;
                if (response.IsSuccessStatusCode)
                {
                    var reservation = await response.Content.ReadAsStringAsync();
                    var EmpInfo = JsonConvert.DeserializeObject<IEnumerable<Reservations>>(reservation);
                    foreach (var entry in EmpInfo)
                    {
                        table.Append("<tr'>");
                        table.Append("<td>" + entry.Id + "</td>");
                        table.Append("<td>" + entry.Name + "</td>");
                        table.Append("<td>" + entry.Surname + "</td>");
                        table.Append("<td>" + entry.Email + "</td>");
                        table.Append("<td>" + entry.MobileNumber + "</td>");
                        table.Append("</tr>");
                    }
                }

                table.Append("</table");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
            }
            else
            {
                Response.Write("<script>alert('Doplňte prosím příjmení.')</script>");
            }
        }

    }
}