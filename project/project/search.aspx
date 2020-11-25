<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="project.search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" Height="51px"  AutoPostBack="true"
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="181px">
            <asp:ListItem Value="0">---select type--</asp:ListItem>
            <asp:ListItem Value="customer_tb">customer</asp:ListItem>
            <asp:ListItem Value="product_tb">product</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server" Height="23px" Width="158px" 
            AutoPostBack="true" onselectedindexchanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    
        <br />
    
        <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="No records found">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
