<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sales_tb.aspx.cs" Inherits="project.sales_tb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sales Details</title>
    <link rel="Stylesheet" type="text/css" href="salesDSheet.css" />
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script>
        $(function () {
            $("#DropDownList1").change(function () {
                var display = $("#DropDownList1 option:selected").text();
                $("#TextBox5").val(display)
            })
        })
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Header">
    <div class="Header_div">
        <div class="Header_Logo">
        Sales Details
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
    
    </div>
    <div>
        <br />
        Receipt Number : <asp:TextBox ID="TextBox1" runat="server" 
            ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        Date : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Customer Name : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
       
    </div>
    <br />
    <div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        Total Price : <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Product Name : 
        <asp:DropDownList ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Price : 
        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox>
    </div>
    <br />
    <div>
    <div class="center">
        <asp:Button ID="Button1" runat="server" Text="Add New" 
            onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Save" onclick="Button2_Click"   />
        
        &nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="Button3" runat="server" Text="Update" 
            onclick="Button3_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Delete" 
            onclick="Button4_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Cancel" 
            onclick="Button5_Click"   />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
            Text="ADD (+)" />
        </div>

        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </div>
    <div>
    <div class="center">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" style="text-align: center"
         >
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
    </div>
    </form>
</body>
</html>
