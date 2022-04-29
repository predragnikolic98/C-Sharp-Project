<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Administrator.aspx.cs" Inherits="ReservationSystemWEB.Administrator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Přehled všech rezervací: </h3>
            <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
            <h3>Vyhledat konkrétní rezervaci: </h3>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Email: " style="margin-right: 11%;"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:PlaceHolder ID = "PlaceHolder2" runat="server" />
         <p>
            <asp:Button ID="Button2" runat="server" Text="Dále" OnClick="Button1_Click"  />
        </p>

        </div>
    </form>
</body>
</html>
