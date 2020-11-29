<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sales_tb.aspx.cs" Inherits="project.sales_tb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <div>
    
    </div>
    <div>
        receipt no : <asp:TextBox ID="TextBox1" runat="server" 
            ReadOnly="True"></asp:TextBox>
        Date : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        customer name : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        
        Total price : <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
       
    </div>
    <br />
    <div>
    product name: 
        <asp:DropDownList ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;&nbsp;
    price : 
        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Add New" 
            onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Save" onclick="Button2_Click"   />
        
        <asp:Button ID="Button3" runat="server" Text="Update" 
            onclick="Button3_Click"  />
        <asp:Button ID="Button4" runat="server" Text="Delete" 
            onclick="Button4_Click"  />
        <asp:Button ID="Button5" runat="server" Text="Cancel" 
            onclick="Button5_Click"   />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
            Text="ADD (+)" />

        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </div>
    <div>
    
        <asp:GridView ID="GridView1" runat="server"
         >
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
