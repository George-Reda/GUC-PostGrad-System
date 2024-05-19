<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListThesis.aspx.cs" Inherits="GUCPostGradSystem.ListThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" GridLines="Both" Width="1285px">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Thesis_title</asp:TableCell>
                    <asp:TableCell runat="server">supervisor_name</asp:TableCell>
                    <asp:TableCell runat="server">student_name</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
