<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication8.WebForm6" %>

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
                 <p>Enter course code <asp:TextBox ID="TextBox1" runat="server"/></p>
            </div>
            <div id="jj" class="questions">
                <h3>1. Enter the question: <asp:TextBox ID="TextBox2" runat="server" CssClass="myTextField"/></h3>
                <p>A. Enter the first option: <asp:TextBox ID="TextBox3" runat="server"/></p>
                <p>B. Enter the second option: <asp:TextBox ID="TextBox4" runat="server"/></p>
                <p>C. Enter the third option: <asp:TextBox ID="TextBox5" runat="server"/></p>
                <p>D. Enter the fourth option: <asp:TextBox ID="TextBox6" runat="server"/></p>

                <p>Enter the Answer:  <asp:TextBox ID="TextBox7" runat="server"/></p>
            </div>

            <div id="Div1" class="questions">
                <h3>2. Enter the question: <asp:TextBox ID="TextBox8" runat="server"/></h3>
                <p>A. Enter the first option: <asp:TextBox ID="TextBox9" runat="server"/></p>
                <p>B. Enter the second option: <asp:TextBox ID="TextBox10" runat="server"/></p>
                <p>C. Enter the third option: <asp:TextBox ID="TextBox11" runat="server"/></p>
                <p>D. Enter the fourth option: <asp:TextBox ID="TextBox12" runat="server"/></p>

                <p>Enter the Answer:  <asp:TextBox ID="TextBox13" runat="server"/></p>
            </div>

            <div id="Div2" class="questions">
                 <h3>3. Enter the question: <asp:TextBox ID="TextBox14" runat="server"/></h3>
                <p>A. Enter the first option: <asp:TextBox ID="TextBox15" runat="server"/></p>
                <p>B. Enter the second option: <asp:TextBox ID="TextBox16" runat="server"/></p>
                <p>C. Enter the third option: <asp:TextBox ID="TextBox17" runat="server"/></p>
                <p>D. Enter the fourth option: <asp:TextBox ID="TextBox18" runat="server"/></p>

                <p>Enter the Answer:  <asp:TextBox ID="TextBox19" runat="server"/></p>
            </div>

            <div id="Div3" class="questions">
                <h3>4. Enter the question: <asp:TextBox ID="TextBox20" runat="server"/></h3>
                <p>A. Enter the first option: <asp:TextBox ID="TextBox21" runat="server"/></p>
                <p>B. Enter the second option: <asp:TextBox ID="TextBox22" runat="server"/></p>
                <p>C. Enter the third option: <asp:TextBox ID="TextBox23" runat="server"/></p>
                <p>D. Enter the fourth option: <asp:TextBox ID="TextBox24" runat="server"/></p>

                <p>Enter the Answer:  <asp:TextBox ID="TextBox25" runat="server"/></p>
            </div>

            <div id="Div4" class="questions">
                <h3>5. Enter the question: <asp:TextBox ID="TextBox26" runat="server"/></h3>
                <p>A. Enter the first option: <asp:TextBox ID="TextBox27" runat="server"/></p>
                <p>B Enter the second option: <asp:TextBox ID="TextBox28" runat="server"/></p>
                <p>C. Enter the third option: <asp:TextBox ID="TextBox29" runat="server"/></p>
                <p>D. Enter the fourth option: <asp:TextBox ID="TextBox30" runat="server"/></p>
                <p>Enter the answer<asp:TextBox ID="TextBox31" runat="server"/></p>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn" OnClick="submitAction"/>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </p>
            <div>
            </div>
        </div>
    </form>
</body>
</html>