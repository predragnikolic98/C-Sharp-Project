<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ReservationSystemWEB.HomePage" %>


<!DOCTYPE html>
<script runat="server"></script>
<html lang="en">
<head runat="server">
<title>Home</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
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
    
    <div class="w3-top">
      <div class="w3-bar w3-black w3-card">
        <a class="w3-bar-item w3-button w3-padding-large w3-hide-medium w3-hide-large w3-right" href="javascript:void(0)" onclick="myFunction()" title="Toggle Navigation Menu"><i class="fa fa-bars"></i></a>
        <a href="HomePage.aspx" class="w3-bar-item w3-button w3-padding-large">HOME</a>
        <a href="Cancellation.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">ZRUŠENÍ REZERVACE</a>
      </div>
    </div>

    
      <div class="w3-container w3-content w3-center w3-padding-64" style="max-width:800px" id="band">
        <h2 class="w3-wide">Rezervační systém sedadel</h2>
        <br>
        <div>
            
            <asp:CheckBoxList ID="CheckBoxList1" OnCheckedChanged="checkboxAttendanceStatus_CheckedChanged" runat="server" CssClass="mycheckbox"
                         AutoPostBack="True"
                         CellPadding="15"
                         CellSpacing="15"
                         RepeatColumns="10"
                         RepeatDirection="Horizontal"
                         RepeatLayout="Flow"
                         TextAlign="Right">
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="1"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="2"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="3"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="4"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="5"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="6"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="7"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="8"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="9"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="10"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="11"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="12"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="13"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="14"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="15"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="16"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="17"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="18"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="19"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="20"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="21"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="22"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="23"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="24"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="25"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="26"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="27"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="28"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="29"></asp:ListItem>
                <asp:ListItem Style="color:#fff;font-size:0.0001em; text-indent:-9999px" Value="30"></asp:ListItem>
            </asp:CheckBoxList>
        </div>
      </div>

      <div class="w3-container w3-content w3-padding-64" style="max-width:800px" id="contact">
        <h2 class="w3-wide w3-center">Vaše rezervace</h2>
        <div class="w3-row w3-padding-32">
            <form action="/action_page.php" target="_blank">
              <div class="w3-row-padding" style="margin:0 -16px 8px -16px">
                <div class="w3-half">
                 <asp:TextBox class="w3-input w3-border" ID="txtName" runat="server" placeholder="Jméno"></asp:TextBox>
                </div>
                <div class="w3-half">
                  <asp:TextBox class="w3-input w3-border" ID="txtSurname" runat="server" placeholder="Příjmeni"></asp:TextBox>
                </div>
              </div>
              <div class="w3-row-padding" style="margin:0 -16px 8px -16px">
                <div class="w3-half">
                  <asp:TextBox class="w3-input w3-border" ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox>
                </div>
                <div class="w3-half">
                  <asp:TextBox class="w3-input w3-border" ID="txtTelNumber" runat="server" placeholder="Telefon"></asp:TextBox>
                </div>
              </div>
              <asp:Button class="w3-button w3-black w3-section w3-right" ID="Button1" runat="server" Text="REZERVOVAT" OnClick="Button1_Click"/>
            </form>        
        </div>
      </div>
    </div>
    <footer class="w3-container w3-padding-64 w3-center w3-opacity w3-light-grey w3-xlarge">
      <p class="w3-medium">C# Projekt</p>
    </footer>
 </form>
</body>
</html>