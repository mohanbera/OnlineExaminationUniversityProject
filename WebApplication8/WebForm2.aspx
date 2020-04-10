<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication8.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link rel="stylesheet" href="StyleSheet.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="appBar">
            <div id="label1" runat="server"></div>
        </div>
        <div class="card1">
            <div class="card2" id="testList" runat="server">

            </div>
            <div class="card3">
                <p>Enter a test code <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="start" OnClick="Button1_Click" />
                    <p>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </p>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
