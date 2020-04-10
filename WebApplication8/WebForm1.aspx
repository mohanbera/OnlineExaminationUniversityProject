<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="StyleSheet.css" type="text/css" />
</head>
<body>
    
    <form id="form1" runat="server">
        <div class="appBar">
            <h3>Login Here</h3>
        </div>
    <div class="card" id="card" runat="server">
          
        <div class="topPadding">
            <p>
            Reg No 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>Password 
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
                <asp:RadioButtonList cssClass="drop" ID="RadioButtonList1" runat="server" Height="30px" Width="77px">
                <asp:ListItem>student </asp:ListItem>
                <asp:ListItem>faculty</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <p></p>
            <p>
                <asp:Button ID="Button2" runat="server" Text='Cancel' OnClick="Button2_Click" />
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
        </div>  
        
    </div>
    </form>
</body>
</html>
