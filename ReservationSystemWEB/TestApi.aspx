<%@ Page Language="C#" Async="True" AutoEventWireup="true" CodeBehind="TestApi.aspx.cs" Inherits="ReservationSystemWEB.TestApi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                    <asp:Button runat="server" ID="submit" OnClick="Calculate_click" Text="Calculate"/>
                    Result : <asp:Literal ID="ltrResult" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
