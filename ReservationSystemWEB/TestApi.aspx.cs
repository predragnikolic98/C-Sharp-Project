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
    public partial class TestApi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async void Calculate_click(object sender, EventArgs e)
        {

            Reservations dt = new Reservations();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44350/");
            //HttpResponseMessage response = client.GetAsync("api/values?name=Jan").Result;
            client.DefaultRequestHeaders.Accept.Clear(); 
            HttpResponseMessage response = client.GetAsync("api/values").Result;
            if (response.IsSuccessStatusCode)
            {
                var reservation = await response.Content.ReadAsStringAsync();
                Response.Write(reservation);
                var EmpInfo = JsonConvert.DeserializeObject<IEnumerable<Reservations>>(reservation);
                //dt = (Reservations)JsonConvert.DeserializeObject(reservation, typeof(Reservations));
                //Response.Write(dt.Name);
                foreach (var entry in EmpInfo)
                {
                    Response.Write(entry.Id);
                    //Response.Write(entry.Name);
                    Response.Write(entry.Surname);
                    Response.Write(entry.Email);
                    Response.Write(entry.MobileNumber);
                }
            }

            /*
            IEnumerable<Students> students = StudentsOfSubject(db, "BPC-EL1");
            IEnumerable<Subjects> subjects = SubjectsOfStudent(db, 230618);


            Console.WriteLine("Zaci v predmetu BPC-EL1: ");
            foreach (var entry in students)
            {
                Console.WriteLine(entry.Name+" "+entry.Surname);
            }

            Console.WriteLine();
            Console.WriteLine("Predmety zaka 230618: ");
            foreach (var entry in subjects)
            {
                Console.WriteLine(entry.Abbreviation);
            }


            
             */
        }
    }
}