<<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SendMail" %>
    
<!DOCTYPE html>
<script runat="server">

    protected void txtto_TextChanged(object sender, EventArgs e)
    {

    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">    
<head id="Head1" runat="server">    
    <title></title>       
</head>    
<body>    
    <br /><br /><br />    
    
                    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>    
    
    <form id="form1" runat="server">    
        <div class="card col-lg-6 col-sm-12 col-md-6">    
            <div class="row">    
                <div class="col-sm-12 col-md-6 col-lg-6">    
                    <asp:Label ID="Label1" runat="server" Text="Enter Receiver Email"></asp:Label>    
                </div>    
                <div class="col-sm-12 col-md-6 col-lg-6">    
                    <asp:TextBox ID="txtto" CssClass="form-control" runat="server" 
                        ontextchanged="txtto_TextChanged"></asp:TextBox>    
                </div>    
            </div>    
    
            <div class="row">    
                <div class="col-sm-12 col-md-6 col-lg-6">    
                    <asp:Label ID="Label2" runat="server" Text="Enter Subject"></asp:Label>    
                </div>    
                <div class="col-sm-12 col-md-6 col-lg-6">    
                    <asp:TextBox ID="txtsub" CssClass="form-control" runat="server"></asp:TextBox>    
                </div>    
            </div>    
    
            <div class="row">    
                <div class="col-sm-12 col-md-6 col-lg-6">    
                    <asp:Label ID="Label3" runat="server" Text="Enter Message"></asp:Label>    
                </div>    
                <div class="col-sm-12 col-md-6 col-lg-6">    
                    <textarea id="txtmsg" class="form-control" cols="20" rows="5" name="txtmsg" onclick="return txtmsg_onclick()"></textarea>    
                </div>    
            </div>    
            <div class="row text-center">    
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="Send Mail" OnClick="Button1_Click" />    
            </div>    
        </div>    
    </form>    
    
</body>    
</html>   