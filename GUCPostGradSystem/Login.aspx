<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCPostGradSystem.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            position: absolute;
            top: 47px;
            left: 9px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 133px;
            left: 9px;
            z-index: 1;
            height: 25px;
        }
        .auto-style4 {
            position: absolute;
            top: 195px;
            left: 13px;
            z-index: 1;
        }
        .auto-style5 {
            margin-left: 72px;
        }
        .auto-style6 {
            margin-left: 122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName</div>
        <asp:TextBox ID="UserName" runat="server" CssClass="auto-style2"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            Pasword</p>
        <asp:TextBox ID="Password" runat="server" CssClass="auto-style3"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="LoginButton" CssClass="auto-style4" Text="SUBMIT" />
        <asp:Button ID="student" runat="server" OnClick="studentRegister" Text="register as a student" Width="278px" />
        <asp:Button ID="supervisor" runat="server" OnClick="supervisorRegister" Text="register as a supervisor" Width="249px" CssClass="auto-style6" />
        <asp:Button ID="examiner" runat="server" OnClick="examinerRegister" Text="register as a examiner" Width="354px" CssClass="auto-style5" />
    </form>
</body>
</html>
