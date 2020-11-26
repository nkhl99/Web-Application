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
    <div class="container">
		<div class="contact-box">
			<div class="left"></div>
			<div class="right">
				<h2>Contact Us</h2>
				<input type="text" class="field" placeholder="Your Name"/>
				<input type="text" class="field" placeholder="Your Email"/>
				<input type="text" class="field" placeholder="Phone"/>
				<textarea placeholder="Message" class="field"></textarea>

				<button type="submit" class="btn">Send</button>
			</div>
		</div>
	</div>
    </form>
</body>
</html>
