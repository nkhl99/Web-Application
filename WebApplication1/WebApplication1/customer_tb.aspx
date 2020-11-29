<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer_tb.aspx.cs" Inherits="project.customer_details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Details</title>
    <link rel="Stylesheet" type="text/css" href="customerDSheet.css" />
    <script type="text/C#">
        function asgConfirmOkCancel() {
            var x = confirm("do you sure want to update");
            if (x == true) {

            }
            else {
                document.write("cancel");
            }
        }

        function ConfirmMessage() {

            if (confirm("are you sure?")) {
                $("HiddenField1").val
            }
            else {
                document.write("cancel");
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Header">
    <div class="Header_div">
        <div class="Header_Logo">
        Customer Details
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
    <%--  <div style="height: 187px">
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>--%>
    <div>
        <br />
        customer Id : <asp:TextBox ID="TextBox1" runat="server" 
            ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        First name : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        Last name : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Mobile : <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Email : <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        State : <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Country : <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        Pincode : <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>

    </div>
    <div>
    <div class="center">
        <asp:Button ID="Button1" runat="server" Text="Add New" 
            onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Save" onclick="Button2_Click" />
        
        &nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="Button3" runat="server" Text="Update" onclick="Button3_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Delete" onclick="Button4_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Cancel" onclick="Button5_Click" />

        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
</div>
    </div>
    <div>

        <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="True" 
            EmptyDataText="No records found" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AutoGenerateSelectButton="True" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
            style="text-align: center">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>

    </div>
    </form>
</body>
</html>
