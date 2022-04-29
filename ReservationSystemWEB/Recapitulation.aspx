<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recapitulation.aspx.cs" Inherits="ReservationSystemWEB.Recapitulation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
<title>Vaše rezervace</title>
</head>
<body>
<form id="form1" runat="server">
    
    <div class="w3-top">
      <div class="w3-bar w3-black w3-card">
        <a class="w3-bar-item w3-button w3-padding-large w3-hide-medium w3-hide-large w3-right" href="javascript:void(0)" onclick="myFunction()" title="Toggle Navigation Menu"><i class="fa fa-bars"></i></a>
        <a href="HomePage.aspx" class="w3-bar-item w3-button w3-padding-large">HOME</a>
        <a href="Cancellation.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">ZRUŠENÍ REZERVACE</a>
      </div>
    </div>

    
      <div class="w3-container w3-content w3-center w3-padding-64" style="max-width:800px" id="band">
        <h2 class="w3-wide">Rekapitulace</h2>
        
        <div>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Jméno: "></asp:Label>
                <asp:Label ID="Label2" runat="server"><% =Session["name"]%></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Příjmení: "></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Label"><% =Session["surname"]%></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text="Email: "></asp:Label>
                <asp:Label ID="Label6" runat="server" Text="Label"><% =Session["email"]%></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label7" runat="server" Text="Telefonní číslo: "></asp:Label>
                <asp:Label ID="Label8" runat="server" Text="Label"><% =Session["telNumber"]%></asp:Label>
            </p> 
                        <p>
                <asp:Label ID="Label9" runat="server" Text="Rezervované sedadla: "></asp:Label>
                <asp:Label ID="Label10" runat="server" Text="Label"><% =Session["seats"]%></asp:Label>
            </p> 
        </div>
    </form>
    <a class="w3-button w3-black w3-section w3-center" href="HomePage.aspx">Home page</a>
</div>
</body>
</html>
