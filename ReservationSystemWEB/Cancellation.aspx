﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cancellation.aspx.cs" Inherits="ReservationSystemWEB.Cancellation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<title>Zrušení rezervace</title>
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
        <h2 class="w3-wide">Zrušení rezervace</h2>
            <div>
                        
            <p>Pro zrušení rezervace doplňte následující informace: </p>
            <div class="w3-row-padding" style="margin:0 -16px 8px -16px">
                <div class="w3-half">
                  <asp:Label ID="Label2" runat="server"></asp:Label>
                  <asp:TextBox class="w3-input w3-border" ID="txtSurname" runat="server" placeholder="Příjmeni"></asp:TextBox>
                </div>
                <div class="w3-half">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                  <asp:TextBox class="w3-input w3-border" ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox>
                </div>
              </div>
             <p>
                <asp:Label ID="Label4" runat="server"><% =Session["Message"]%></asp:Label>
            </p>
            <p>
              <asp:Button class="w3-button w3-black w3-section w3-center" ID="Button1" runat="server" Text="Potvrdít" OnClick="Button1_Click" />
            </p>
            </div>
        </form>
      </div>
</body>
</html>
