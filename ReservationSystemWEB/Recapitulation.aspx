<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recapitulation.aspx.cs" Inherits="ReservationSystemWEB.Recapitulation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h3>Rekapitulace: </h3>
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
</body>
</html>
