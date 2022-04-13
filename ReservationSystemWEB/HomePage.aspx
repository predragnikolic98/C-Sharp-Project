<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ReservationSystemWEB.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">

.mycheckbox td
{
   border:1px solid #f2f2f2;
   line-height:30px;
}

.mycheckbox td label
{
    line-height:30px;
    color:#f2f2f2;
}
  
#div1 {
    float:left;
    margin-left: 7%;
    margin-top: 2%;

}
#div2 {
    float:right;
    margin-right: 13%;
    margin-top: 2%;
}
       
[type="checkbox"]{
  width:40px;
  height:40px;
  margin:10px;
  border-radius: 50%;
  border:5px dashed #000;
}

  .Button
    {
        border-style :solid;
        font-family :Monotype Corsiva;
        background-color:Black;
        color:Red;   
    } 
        </style>
</head>
<body>
    <h2>Rezervační systém</h2>
    <form id="form1" runat="server" style="border-style: solid">
        <div id="div1">
            <asp:Label ID="Label5" runat="server" Text="Sedadla: "></asp:Label>
             <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="mycheckbox"
                         AutoPostBack="True"
                         CellPadding="15"
                         CellSpacing="15"
                         RepeatColumns="10"
                         RepeatDirection="Horizontal"
                         RepeatLayout="Flow"
                         TextAlign="Right">
                <asp:ListItem>  1 </asp:ListItem>
                <asp:ListItem>  2 </asp:ListItem>
                <asp:ListItem>  3 </asp:ListItem>
                <asp:ListItem>  4 </asp:ListItem>
                <asp:ListItem>  5 </asp:ListItem>
                <asp:ListItem>  6 </asp:ListItem>
                <asp:ListItem>  7 </asp:ListItem>
                <asp:ListItem>  8  </asp:ListItem>
                <asp:ListItem>  9  </asp:ListItem>
                <asp:ListItem> 10</asp:ListItem>
                <asp:ListItem> 11</asp:ListItem>
                <asp:ListItem> 12</asp:ListItem>
                <asp:ListItem> 13</asp:ListItem>
                <asp:ListItem> 14</asp:ListItem>
                <asp:ListItem> 15</asp:ListItem>
                <asp:ListItem> 16</asp:ListItem>
                <asp:ListItem> 17</asp:ListItem>
                <asp:ListItem> 18</asp:ListItem>
                <asp:ListItem> 19</asp:ListItem>
                <asp:ListItem> 20</asp:ListItem>
                <asp:ListItem> 21</asp:ListItem>
                <asp:ListItem> 22</asp:ListItem>
                <asp:ListItem> 23</asp:ListItem>
                <asp:ListItem> 24</asp:ListItem>
                <asp:ListItem> 25</asp:ListItem>
                <asp:ListItem> 26</asp:ListItem>
                <asp:ListItem> 27</asp:ListItem>
                <asp:ListItem> 28</asp:ListItem>
                <asp:ListItem> 29</asp:ListItem>
                <asp:ListItem> 30</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div id="div2">
            <asp:Label ID="Label7" runat="server" Text="Kontaktní údaje: "></asp:Label>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Jméno: " style="margin-right: 16%;"></asp:Label> 
            <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
        </p>
            
        <p>
            <asp:Label ID="Label2" runat="server" Text="Příjmeni: " style="margin-right: 11%;"></asp:Label>
            <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        </p>
            
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email: " style="margin-right: 17.7%;"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>

        <p>
            <asp:Label ID="Label4" runat="server" Text="Mobilní číslo: "></asp:Label>

            <asp:TextBox ID="txtTelNumber" runat="server"></asp:TextBox>
        </p>

        <p>
            <asp:Button ID="Button1" runat="server" Text="Dále" OnClick="Button1_Click" />
        </p>
    </div>

    </form>
        <!--<asp:Label ID="Label8" runat="server"><% =Session["Mess"]%></asp:Label> -->
    <!--<a href="Recapitulation.aspx">Zrušení rezervace</a>-->
    </body>
</html>
