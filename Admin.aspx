<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="LasVegasMagicShow.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="all-div">
             <div id="LabelTitle2">
            <asp:Label ID="Label_login" runat="server" Text="Login text label"></asp:Label>
        </div>
        &nbsp;<br />
            <div id="con1">
&nbsp;<br /><div id="leftSide">
        Your info:<br />
        <asp:Label ID="Userinfo" runat="server" Text="Userinfo label"></asp:Label>
        <br /></div>
        <br /><div id="middle">
            <asp:Label ID="Label1" runat="server" Text="New Name:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <br />
            <asp:Label ID="Label2" runat="server" Text="New Password:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
             <br />
        <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update info" />
             <br />
        <br />
            <asp:Label ID="Label3" runat="server" Text="New Salary:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxSal" runat="server"></asp:TextBox>
        <br />
            <asp:Label ID="Label4" runat="server" Text="New Trick:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBoxFavTricks" runat="server"></asp:TextBox>
        <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        <br />
        <br />

            </div>
        <br />
            <div id="rightSide">
        List of other users:<br />
        <asp:ListBox ID="ListBoxUsers" runat="server" Height="358px" Width="647px" Rows="2"></asp:ListBox>
       </div> 

            

        </div>
           
        </div>
    </form>
</body>
</html>
