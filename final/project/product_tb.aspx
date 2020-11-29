<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product_tb.aspx.cs" Inherits="project.product_tb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
    </div>
    <div>
        product Id : <asp:TextBox ID="TextBox1" runat="server" 
            ReadOnly="True"></asp:TextBox>
        product name : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        product price : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        manufacture : <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        rating : <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
       

    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Add New" 
            onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Save" onclick="Button2_Click"  />
        
        <asp:Button ID="Button3" runat="server" Text="Update" 
            onclick="Button3_Click"  />
        <asp:Button ID="Button4" runat="server" Text="Delete" onclick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="Cancel" 
            onclick="Button5_Click"  />

        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </div>
    </form>
</body>
</html>
