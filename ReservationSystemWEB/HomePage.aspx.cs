﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationSystemWEB
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtName.Text != string.Empty && txtSurname.Text != string.Empty && txtTelNumber.Text != string.Empty && CheckBoxList1.SelectedItem != null)
            {
                Session["Name"] = txtName.Text;
                Session["Surname"] = txtSurname.Text;
                Session["Email"] = txtEmail.Text;
                Session["Mobil"] = txtTelNumber.Text;

                LinqToSQLDataContext db = new LinqToSQLDataContext();

                string hobList = string.Empty;
                foreach (ListItem hob in CheckBoxList1.Items)
                {
                    if (hob.Selected == true)
                    {
                        hobList += string.Format("{0} ", hob.Text);
                        Reservation newReservation = new Reservation() { ID = Convert.ToInt32(hob.Text), Name = txtName.Text, Surname = txtSurname.Text, 
                        Email = txtEmail.Text, MobileNumber = txtTelNumber.Text };
                        db.Reservation.InsertOnSubmit(newReservation);
                    }
                }
                db.SubmitChanges();



                /* int[] array1 = new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1 };
                 for (var i = 0; i < CheckBoxList1.Items.Count; i++)
                 {   
                     if(array1[i] == 2)
                     Response.Write(""+ CheckBoxList1.Item[i]);
                     Console.WriteLine("Amount is {0} and type is {1}", myMoney[i].amount, myMoney[i].type);
                 }*/

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
                //Session["Mess"] = "ney";
                Response.Write("<script>alert('Nebyly vyplněné všechny udáje potřebné k dokončení rezervace')</script>");
            }

        }
    }
}