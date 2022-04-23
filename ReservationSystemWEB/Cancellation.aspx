<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cancellation.aspx.cs" Inherits="ReservationSystemWEB.Cancellation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <h3>Zrušení rezervace: </h3>
            <p>Pro zrušení rezervace doplňte následující informace: </p>
            
        <p>
            <asp:Label ID="Label2" runat="server" Text="Příjmeni: "></asp:Label>
            <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        </p>
            
         <p>
            <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
         </p>
         <p>
            <asp:Label ID="Label4" runat="server"><% =Session["Message"]%></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Dále" OnClick="Button1_Click" />
        </p>
        </div>
    </form>
</body>
</html>
