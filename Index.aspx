<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LasVegasMagicShow.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="all-div">
            <div class="auto-style2">

                  <center>
            <asp:Label ID="LabelTitle" runat="server" Text="LAS VEGAS MAGICAL"></asp:Label>
            <br />
            <asp:Label ID="LabelTitle1" runat="server" Text="SHOW"></asp:Label>
    </center>
        <div id="loginbBox">
            &nbsp;<asp:Label ID="LabelUser" runat="server" Text="USERNAME"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox_username" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="PASSWORD"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox_password" runat="server"></asp:TextBox>
            <br /></div>
            <br /> <center>
            <asp:Button ID="Button_login" runat="server" Text="LOGIN" Width="90px" OnClick="Button_login_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="Button_signup" runat="server" CssClass="auto-style3" style="text-align: left" Text="SIGNUP" Width="90px" OnClick="Button_signup_Click" />
            <br /></center>
            <br />
            <br />
            
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="203px" Width="750px" Visible="False"></asp:ListBox>
        </div>
    </form>
</body>
</html>
