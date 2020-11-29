<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product_tb.aspx.cs" Inherits="project.product_tb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Details</title>
    <link rel="Stylesheet" type="text/css" href="productDSheet.css" />
</head>
<body>
        <form id="form1" runat="server">
    <div class="Header">
    <div class="Header_div">
        <div class="Header_Logo">
        Product Details
        </div>
        <div class="Header_Menu">
        <ul>
        <li><a href="About_us.aspx">ABOUT US</a></li>
        <li><a href="search.aspx">SEARCH</a></li>
        <li><a href="log1.aspx">LOGOUT</a></li>
        </ul>
        </div>
    
    </div>
    </div>
    <div>
    
        <br />
    </div>
    <div>
        product Id : <asp:TextBox ID="TextBox1" runat="server" 
            ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Product Name : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Product Price : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        Manufacture : <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Rating : <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
       

    </div>
    <div>
    <div class="center">
        <asp:Button ID="Button1" runat="server" Text="Add New" 
            onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Save" onclick="Button2_Click"  />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="Button3" runat="server" Text="Update" 
            onclick="Button3_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Delete" onclick="Button4_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Cancel" 
            onclick="Button5_Click"  />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
