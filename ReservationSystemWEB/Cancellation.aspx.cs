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
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                Session["Email"] = txtEmail.Text;

                //to bude při splnění odstranění rezervace, tedy metoda která bude odstraňovat rezervaci bude typu boolean.
                Session["Message"] = "Rezervace byla úspěšně zrušena";

                String email = txtEmail.Text;

                Reservations dt = new Reservations();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44350/");
                //HttpResponseMessage response = client.GetAsync("api/values?name=Jan").Result;
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = client.DeleteAsync("api/values?email=" + txtEmail.Text + "").Result;
                if (response.IsSuccessStatusCode)
                {

                }

                Response.Write(email);

            }
            else
            {
                Response.Write("<script>alert('Nebyly vyplněné všechny udáje potřebné k dokončení rezervace')</script>");
            }

        }
    }
}