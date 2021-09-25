<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="LoginPage.aspx.cs" Inherits="LoginPage.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="css/style.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="center">
            <h1>Login</h1>
            <div class="form">
                <div class="text_field">
                    <asp:TextBox ID="txt_username" required="required" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="validator_email" runat="server" ErrorMessage="Please enter valid e-mail address" ControlToValidate="txt_username" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <span class="animation"></span>
                    <span class="info"><i class="fas fa-user"></i>Username</span>

                </div>
                <div class="text_field">
                    <asp:TextBox ID="txt_password" required="required" TextMode="Password" runat="server"></asp:TextBox>
                    <span class="animation"></span>
                    <span class="info"><i class="fas fa-lock"></i>Password</span>
                </div>
                <div class="remember">
                    Remember Me
                    <asp:CheckBox ID="checkbox" runat="server" />
                </div>
                <div class="button">
                    <asp:Button ID="Btn_login" runat="server" Text="Login" OnClick="Btn_login_Click" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
                <div class="register">
                    Don't have an account?
                    <br />
                    <a href="RegisterPage.aspx">Register now</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
