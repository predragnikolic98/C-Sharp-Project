using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationSystemWEB
{
    public partial class Cancellation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtName.Text != string.Empty && txtSurname.Text != string.Empty)
            {
                Session["Name"] = txtName.Text;
                Session["Surname"] = txtSurname.Text;
                Session["Email"] = txtEmail.Text;

                //to bude při splnění odstranění rezervace, tedy metoda která bude odstraňovat rezervaci bude typu boolean.
                Session["Message"] = "Rezervace byla úspěšně zrušena";

                String name = txtName.Text;
                String surname = txtSurname.Text;
                String email = txtEmail.Text;
                Response.Write(name);
                Response.Write(surname);
                Response.Write(email);

            }
            else
            {
                //Session["Mess"] = "ney";
                Response.Write("<script>alert('Nebyly vyplněné všechny udáje potřebné k dokončení rezervace')</script>");
            }

        }
    }
}