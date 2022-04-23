<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ReservationSystemWEB.HomePage" %>

<!DOCTYPE html>

<script runat="server">
</script>

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
            <asp:CheckBoxList ID="CheckBoxList1" OnCheckedChanged="checkboxAttendanceStatus_CheckedChanged" runat="server" CssClass="mycheckbox"
                         AutoPostBack="True"
                         CellPadding="15"
                         CellSpacing="15"
                         RepeatColumns="10"
                         RepeatDirection="Horizontal"
                         RepeatLayout="Flow"
                         TextAlign="Right">
                <asp:ListItem Text="1" Value="1" OnCheckedChanged="checkboxAttendanceStatus_CheckedChanged"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                <asp:ListItem Text="6" Value="6"></asp:ListItem>
                <asp:ListItem Text="7" Value="7"></asp:ListItem>
                <asp:ListItem Text="8" Value="8"></asp:ListItem>
                <asp:ListItem Text="9" Value="9"></asp:ListItem>
                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                <asp:ListItem Text="13" Value="13"></asp:ListItem>
                <asp:ListItem Text="14" Value="14"></asp:ListItem>
                <asp:ListItem Text="15" Value="15"></asp:ListItem>
                <asp:ListItem Text="16" Value="16"></asp:ListItem>
                <asp:ListItem Text="17" Value="17"></asp:ListItem>
                <asp:ListItem Text="18" Value="18"></asp:ListItem>
                <asp:ListItem Text="19" Value="19"></asp:ListItem>
                <asp:ListItem Text="20" Value="20"></asp:ListItem>
                <asp:ListItem Text="21" Value="21"></asp:ListItem>
                <asp:ListItem Text="22" Value="22"></asp:ListItem>
                <asp:ListItem Text="23" Value="23"></asp:ListItem>
                <asp:ListItem Text="24" Value="24"></asp:ListItem>
                <asp:ListItem Text="25" Value="25"></asp:ListItem>
                <asp:ListItem Text="26" Value="26"></asp:ListItem>
                <asp:ListItem Text="27" Value="27"></asp:ListItem>
                <asp:ListItem Text="28" Value="28"></asp:ListItem>
                <asp:ListItem Text="29" Value="29"></asp:ListItem>
                <asp:ListItem Text="30" Value="30"></asp:ListItem>
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
    <a href="Recapitulation.aspx">Zrušení rezervace</a>
    </body>
</html>
