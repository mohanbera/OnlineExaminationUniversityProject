<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication8.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            <div class="card9">
                <asp:Button ID="Button1" runat="server" class="myBtn" Text="Add questions" OnClick="createQuestion"/>
            </div>
            <div class="card7" id="card7" runat="server">
            </div>
        </div>
    </form>
</body>
</html>