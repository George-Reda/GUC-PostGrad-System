<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addgrade.aspx.cs" Inherits="GUCPostGradSystem.addgrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <p>
            Thesis_Serial_No.</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <p>
            Defense_Date</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <p>
            grade you want to enter</p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="insertinginputs" CssClass="auto-style4" Text="Submit the requirments" />
        </p>
    </form>
</body>
</html>
