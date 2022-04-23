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

namespace ReservationSystemWEB
{
    public partial class Administrator : System.Web.UI.Page
    {
 
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString();
                con.Open();



                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from [Reservation]";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();


                //Table start.
                table.Append("<table border = '1'>");
                table.Append("<tr><th> Číslo sedadla </th>" +
                             "<th> Jméno </th>" +
                             "<th> Příjmení </th>" +
                             "<th> Email </th>" +
                             "<th> Telefon </th>");
                table.Append("</tr>");

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        table.Append("<tr'>");
                        table.Append("<td>" + rd[0] + "</td>");
                        table.Append("<td>" + rd[1] + "</td>");
                        table.Append("<td>" + rd[2] + "</td>");
                        table.Append("<td>" + rd[3] + "</td>");
                        table.Append("<td>" + rd[4] + "</td>");
                        table.Append("</tr>");
                    }

                }
                table.Append("</table");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
                rd.Close();


            }


    }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if ( txtSurname.Text != string.Empty)
            {
                //WriteAll();
                Session["Surname"] = txtSurname.Text;

                LinqToSQLDataContext db = new LinqToSQLDataContext();

                var select = from reserv in db.Reservation
                             where reserv.Surname == txtSurname.Text
                             select reserv;


                table.Append("<table border = '1'>");
                table.Append("<tr><th> Číslo sedadla </th>" +
                             "<th> Jméno </th>" +
                             "<th> Příjmení </th>" +
                             "<th> Email </th>" +
                             "<th> Telefon </th>"); 
                table.Append("</tr>");

                foreach (var entry in select)
                {
                    table.Append("<tr'>");
                    table.Append("<td>" + entry.ID + "</td>");
                    table.Append("<td>" + entry.Name + "</td>");
                    table.Append("<td>" + entry.Surname + "</td>");
                    table.Append("<td>" + entry.Email + "</td>");
                    table.Append("<td>" + entry.MobileNumber + "</td>");
                    table.Append("</tr>");
                }

                table.Append("</table");
                PlaceHolder2.Controls.Add(new Literal { Text = table.ToString() });


            }
            else
            {
                Response.Write("<script>alert('Doplňte prosím příjmení.')</script>");
            }
        }
        private void WriteAll()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ToString();
            con.Open();



            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from [Reservation]";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();


            //Table start.
            table.Append("<table border = '1'>");
            table.Append("<tr><th> Číslo sedadla </th>" +
                         "<th> Jméno </th>" +
                         "<th> Příjmení </th>" +
                         "<th> Email </th>" +
                         "<th> Telefon </th>");
            table.Append("</tr>");

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    table.Append("<tr'>");
                    table.Append("<td>" + rd[0] + "</td>");
                    table.Append("<td>" + rd[1] + "</td>");
                    table.Append("<td>" + rd[2] + "</td>");
                    table.Append("<td>" + rd[3] + "</td>");
                    table.Append("<td>" + rd[4] + "</td>");
                    table.Append("</tr>");
                }

            }
            table.Append("</table");
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
            rd.Close();
        }
    }
}