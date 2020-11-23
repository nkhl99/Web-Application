<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log1.aspx.cs" Inherits="WebApplication1.log1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
       <link rel="Stylesheet" type="text/css" href="logSheet1.css" />
       
</head>
<body style="height: 510px">
    <form id="form1" runat="server" style="background-image: none">
    <div  >
        
    </div>
           <br />
           <br />
           <br />
           <h1 class="he">Login</h1>

        
           
    
       
        <br />
        <br />
        <br />
        
    
    <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox class="txti" ID="user" runat="server" BorderColor="Black" Height="31px" 
            Width="163px" ontextchanged="user_TextChanged" placeholder="Enter userid"></asp:TextBox>
        <asp:RequiredFieldValidator class="val_user" ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="user" ErrorMessage="Please enter user id " 
        ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        
        
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox class="txtp" ID="Password" runat="server" BorderColor="Black" Height="31px" 
            ontextchanged="Password_TextChanged" TextMode="Password" Width="163px" 
        placeholder="Enter password"></asp:TextBox>
        <asp:RequiredFieldValidator class="valpassword" ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="Password" ErrorMessage="Please enter password" 
        ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button class="btnln" ID="Button1" runat="server" BackColor="Black" ForeColor="White" 
            Height="31px" onclick="Button1_Click" Text="Login" Width="161px" />
&nbsp;</form>

</body>
</html>
