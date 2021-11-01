<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="LoginPage.asp.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Password</title>
    <link href="../css/forgetpassword.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <center>
                Please enter your e-mail: 
                <br />
                <asp:TextBox ID="email_textbox" runat="server" required="required" ></asp:TextBox>
                <br />
                <asp:Button ID="email_button" runat="server" Text="Get your password" OnClick="email_button_Click"></asp:Button>
                <br />
                <asp:Label ID="email_label" runat="server"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>
