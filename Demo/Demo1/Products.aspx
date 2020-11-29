<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Demo1.Products" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
        <asp:TemplateField HeaderText="ID">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" Text='<%#Eval("ID") %>' runat="server">LinkButton</asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:BoundField HeaderText="Name" DataField="Name" />
        <asp:BoundField HeaderText="Price" DataField="Price" />
        </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
