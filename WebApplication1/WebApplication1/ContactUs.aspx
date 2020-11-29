<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="WebApplication1.ContactUs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact us</title>
	<link rel="stylesheet" type="text/css" href="ContactUsSheet.css"/>
	<link href="https://fonts.googleapis.com/css?family=Quicksand&display=swap" rel="stylesheet"/>
	<meta name="viewport" content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Header">
    <div class="Header_div">
        <div class="Header_Logo">
        </div>
        <div class="Header_Menu">
        <ul>
        <li><a href="About_us.aspx">ABOUT US</a></li>
        <li><a href="search.aspx">BACK</a></li>
        <li><a href="log1.aspx">LOGOUT</a></li>
        </ul>
        </div>
    
    </div>
    </div>
    <div class="container">
		<div class="contact-box">
			<div class="left"></div>
			<div class="right">
				<h2>Contact Us</h2>
				<input type="text" name="names" class="field" placeholder="Your Name"/>
				<input type="text" name="mail" class="field" placeholder="Your Email"/>
				<input type="text" name="phone" class="field" placeholder="Mobile"/>
				<textarea name="body" placeholder="Message" class="field"></textarea>
                <%--<asp:TextBox ID="Textbody" runat="server"></asp:TextBox>
                <br />
                <br />--%>
                <asp:Button ID="Button1" runat="server" Text="Send" onclick="Button1_Click" 
                    BackColor="Silver" BorderColor="#CCCCCC" BorderStyle="Groove" Height="42px" 
                    Width="94px" />
                <%--<button type="submit" class="btn">Send</button>--%>
			</div>
		</div>
	</div>
    </form>
</body>
</html>
