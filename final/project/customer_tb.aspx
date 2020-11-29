<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer_tb.aspx.cs" Inherits="project.customer_details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
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
    <%--  <div style="height: 187px">
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>--%>
    <div>
        customer Id : <asp:TextBox ID="TextBox1" runat="server" 
            ReadOnly="True"></asp:TextBox>
        First name : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        Last name : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        phone number : <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        State :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        Country :&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        Pincode :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>

    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Add New" 
            onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Save" onclick="Button2_Click" />
        
        <asp:Button ID="Button3" runat="server" Text="Update" onclick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Delete" onclick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="Cancel" onclick="Button5_Click" />

        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </div>
    </form>
</body>
</html>
