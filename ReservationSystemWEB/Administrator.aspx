<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Administrator.aspx.cs" Inherits="ReservationSystemWEB.Administrator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
body {font-family: "Lato", sans-serif}
[type="checkbox"]{
  width:40px;
  height:40px;
  margin:10px;
  border-radius: 50%;
  border:5px dashed #000;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Přehled všech rezervací: </h3>
             <asp:Literal ID="ltrResult" runat="server"></asp:Literal>
            <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
            <h3>Vyhledat konkrétní rezervaci: </h3>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Email: " style="margin-right: 11%;"></asp:Label>
            <asp:TextBox ID="txtEmailGet" runat="server"></asp:TextBox>
        </p>
        <asp:PlaceHolder ID = "PlaceHolder2" runat="server" />
         <p>
             <br/>
            <asp:Button ID="Button2" runat="server" Text="Dále" OnClick="Button1_Click"  />
        </p>

        </div>

         <div>
                        
            <p>Zrušení konkrétní rezervace: </p>
            <div>

                <div>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                  <asp:TextBox ID="txtEmailDelete" runat="server" placeholder="Email"></asp:TextBox>
                </div>
              </div>
                <p>
                <asp:Label ID="Label1" runat="server"><% =Session["ChooseSeats"]%></asp:Label>
                </p>
                <asp:CheckBoxList id="chklst" runat="server" OnCheckedChanged="checkboxAttendanceStatus_CheckedChanged" CssClass="mycheckbox"
                         AutoPostBack="True"
                         CellPadding="15"
                         CellSpacing="15"
                         RepeatColumns="10"
                         RepeatDirection="Horizontal"
                         RepeatLayout="Flow"
                         TextAlign="Right" /> <br/>
             <p>
                
                <asp:Label ID="Label4" runat="server"><% =Session["Message"]%></asp:Label>
            </p>
            <p>
                <asp:Button  ID="Button1" runat="server" Text="Dále" OnClick="Button2_Click" />
            </p>
            </div>
    </form>
</body>
</html>
