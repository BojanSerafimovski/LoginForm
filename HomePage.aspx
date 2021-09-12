<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LoginPage.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <link href="css/homepage.css" rel="stylesheet" />
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" />
</head>
<body>
    <form id="form1" runat="server">

        <h1><a href="LoginPage.aspx">Back to Login Page</a></h1>

 <div class="popup hide__popup">
  <div class="popup__content">
    <div class="popup__close">
      <svg>
        <use xlink:href="images/sprite.svg#icon-cross"></use>
      </svg>
    </div>
      <div class="content">
          <h1>Welcome to my test website!</h1>
          <h2>If you made it to this Home Page it means that you've registrated and logged in successfully.
              <br /> <br />
              Thank you for your time and have a nice day! <i class="far fa-smile-beam"></i>
          </h2>
      </div>
   </div>
</div>

    </form>

  <script src="js/popup.js"></script>
</body>
</html>
