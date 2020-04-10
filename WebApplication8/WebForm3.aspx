<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication8.WebForm3" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Home</title>
    <link rel="stylesheet" href="StyleSheet1.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="appBar">
            <div id="label1" runat="server"></div>
        </div>
        <div id="hh" class="card1">
            <div class="questions">
                 <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
            <div id="jj" class="questions">
                <div id="div1" runat="server" >
                   <h4>Text</h4>
                </div>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div class="questions">
                <div id="div2" runat="server" >
                   <h4>Text</h4>
                </div>
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div class="questions">
                <div id="div3" runat="server" >
                   <h4>Text</h4>
                </div>
                <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div class="questions">
                <div id="div4" runat="server" >
                   <h4>Text</h4>
                </div>
                <asp:RadioButtonList ID="RadioButtonList4" runat="server">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div class="questions">
                <div id="div5" runat="server">
                   <h4>Text</h4>
                </div>
                <asp:RadioButtonList ID="RadioButtonList5" runat="server">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn" Onclick="submitAction"/>
        </div>
    </form>
</body>
</html>