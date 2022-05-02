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
    public partial class Cancellation : System.Web.UI.Page
    {

        static bool switchCase = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async void Button2_Click(object sender, EventArgs e)
        {

            if (!switchCase)
            {
                Session["Message"] = "";
                Session["ChooseSeats"] = "";
                Session["Email"] = txtEmail.Text;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44350/");
                HttpResponseMessage response = client.GetAsync("api/values?email=" + txtEmail.Text + "").Result;
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
                        Session["Message"] = "Pro tento email nebyla nalezena žádná rezervace.";

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
                            Session["Email"] = txtEmail.Text;
                            HttpClient client = new HttpClient();
                            client.BaseAddress = new Uri("https://localhost:44350/");
                            HttpResponseMessage response = client.DeleteAsync("api/values/5?email=" + txtEmail.Text + "&id=" + Convert.ToInt32(hob.Text) + "").Result;
                            if (response.IsSuccessStatusCode)
                            {
                                Session["Message"] = "Rezervace byla úspěšně zrušena";
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
                    Session["Message"] = "Zrušení rezervace neproběhlo, protože jste nevybrali žádné sedalo, které chcete zrušit";
                    chklst.Items.Clear();

                    switchCase = false;
                    Button2.Text = "Dále";
                }
            }
        }

    }
}