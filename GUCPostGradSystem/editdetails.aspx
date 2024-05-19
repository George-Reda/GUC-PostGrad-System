<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editdetails.aspx.cs" Inherits="GUCPostGradSystem.editdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             
             <p>
            Please enter your new name</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <p>
            please enter your new field of work </p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
         <p>
            <asp:Button ID="Button1" runat="server" OnClick="updatinginputs" CssClass="auto-style4" Text="Submit the requirments" />
        </p>
        </div>
    </form>
</body>
</html>
