<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchthesis.aspx.cs" Inherits="GUCPostGradSystem.searchthesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 276px;
            height: 28px;
            position: absolute;
            top: 132px;
            left: 10px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div><p>
            please enter the keyword you want to search for</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" onClick="searchThesis" Text="search " />
        </div>
        
        <asp:Table ID="Table1" runat="server" CssClass="auto-style1" GridLines="Both">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Thesis_Title:-</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        

        

    </form>
</body>
</html>
