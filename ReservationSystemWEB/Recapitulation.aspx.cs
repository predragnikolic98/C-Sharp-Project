using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationSystemWEB
{
    public partial class Recapitulation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["name"] = Request.QueryString["Name"];
            Session["surname"] = Request.QueryString["Surname"];
            Session["email"] = Request.QueryString["Email"];
            Session["telNumber"] = Request.QueryString["TelNumber"];
            Session["seats"] = Request.QueryString["CheckList"];
            string seats = Request.QueryString["CheckList"];

            Session["seatsSplitted"] = seats;


        }
    }
}