﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExaminerRegister.aspx.cs" Inherits="GUCPostGradSystem.ExaminerRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <p>
            first_name</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <p>
            last_name</p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <p>
            password</p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
             <p>
            faculty</p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            
             <p>
            email</p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <p>
            fieldOfWork</p>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <p>
            ISnational</p>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            
             <br />
             <br />
            <asp:Button ID="Button1" runat="server" onClick="ExaminerRegister1" Text="submit my requirments" />
            </div>
    </form>
</body>
</html>
