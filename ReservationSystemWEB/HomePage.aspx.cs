using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ReservationSystemWEB
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {

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
                    CheckBoxList1.Items[entry.Id - 1].Enabled = false;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtName.Text != string.Empty && txtSurname.Text != string.Empty && 
                txtTelNumber.Text != string.Empty && CheckBoxList1.SelectedItem != null)
            {
                Session["Name"] = txtName.Text;
                Session["Surname"] = txtSurname.Text;
                Session["Email"] = txtEmail.Text;
                Session["Mobil"] = txtTelNumber.Text;

                string hobList = string.Empty;
                foreach (ListItem hob in CheckBoxList1.Items)
                {

                    if (hob.Selected == true)
                    {
                        Reservations newReservation = new Reservations
                        {
                            Id = Convert.ToInt32(hob.Text),
                            Name = txtName.Text,
                            Surname = txtSurname.Text,
                            Email = txtEmail.Text,
                            MobileNumber = txtTelNumber.Text,

                        };
                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri("https://localhost:44350/");
                        HttpResponseMessage response =
                        client.PostAsJsonAsync("api/values", newReservation).Result;
                        /*
                        if (response.IsSuccessStatusCode)
                        {
                            decimal result = response.Content.ReadAsAsync<decimal>().Result;
                        }*/

                        hobList += string.Format("{0} ", hob.Text);
                        
                    }
                }

                char[] splitter = { ' ' };
                string[] partition = hobList.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

                string splittedSeat = string.Empty;
                for (int i = 0; i < partition.Length; i++)
                {
                    if (i + 1 == partition.Length)
                        splittedSeat += string.Format("{0}.", partition[i]);
                    else
                        splittedSeat += string.Format("{0}, ", partition[i]);
                }

                Response.Redirect(String.Format("Recapitulation.aspx?Name={0}&Surname={1}&Email={2}&TelNumber={3}&CheckList={4}", txtName.Text, txtSurname.Text, txtEmail.Text, txtTelNumber.Text, splittedSeat));
            }
            else
            {
                Response.Write("<script>alert('Nebyly vyplněné všechny udáje potřebné k dokončení rezervace')</script>");
            }

        }
    }
}