<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="RegisterPage.aspx.cs" Inherits="LoginPage.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/style.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" />
    <title>Register Page</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="center">
            <h1>Register</h1>
            <div class="form">
                <div class="text_field">
                    <asp:TextBox ID="txt_textboxemail" required="required" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="validator_registration" runat="server" ErrorMessage="Please enter valid e-mail address" ControlToValidate="txt_textboxemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <span class="animation"></span>
                    <span class="info"><i class="far fa-envelope"></i>E-mail</span>
                </div>
                <div class="text_field">
                    <asp:TextBox ID="txt_password" required="required" TextMode="Password" runat="server"></asp:TextBox>
                    <span class="animation"></span>
                    <span class="info"><i class="fas fa-lock"></i>Password</span>
                </div>
                <div class="button">
                    <asp:Button ID="Btn_register" runat="server" Text="Register" OnClick="Btn_register_Click" />
                    <asp:Label ID="Label_registration" runat="server"></asp:Label>
                </div>
                <div class="register">
                    Already have an account?<br />
                    <a href="LoginPage.aspx">Login here</a>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
