<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examiners.aspx.cs" Inherits="GUCPostGradSystem.Examiners" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
        .auto-style2 {
            position: absolute;
            top: 89px;
            left: 12px;
            z-index: 1;
            width: 737px;
            right: 616px;
        }
        .auto-style3 {
            position: absolute;
            top: 167px;
            left: 10px;
            z-index: 1;
            width: 736px;
        }
        .auto-style4 {
            position: absolute;
            top: 227px;
            left: 10px;
            z-index: 1;
            width: 739px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:Button runat="server" OnClick="editdetails" Text=" Edit my personal information" CssClass="auto-style1" Width="735px" />
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Listdetails" CssClass="auto-style2" Text=" List all theses titles, supervisors, and students names I attended defenses for" />
    </p>

    <p>
        &nbsp;</p>
    <asp:Button ID="Button2" runat="server" OnClick="addcomments" CssClass="auto-style3" Text=" Add comments for a defense." />

    <p>
        &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
    <asp:Button ID="Button3" runat="server" OnClick="addgrade" CssClass="auto-style4" Text="Add grade for a defense." />

    <p>
        &nbsp;</p>
            <p>
                &nbsp;</p>
    <asp:Button ID="Button4" runat="server" OnClick="searchthesis" CssClass="auto-style5" Text=" Search for thesis where the title contains the entered keyword." Width="737px" />

    </form>

        
</body>
</html>
    

