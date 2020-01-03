<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Mobile_Store.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mobile Store</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" runat="server" media="screen" href="~/css/styles.css" />
</head>
<body>
    <nav class="navbar navbar-expand-lg fixed-top navbar-dark bg-dark navbarCustom">
  <a class="navbar-brand" href="Login.aspx">Mobile Store</a>

    <ul class="navbar-nav">
              <li class="nav-item liCustom">
        <a class="nav-link" href="Signup.aspx">Sign Up</a>
      </li>
                   
    </ul>
</nav>
    <form id="form1" runat="server">
        <div class="root">

            <h1 class="display-4 headingMain">Welcome to Mobile Store</h1>

            <div class="loginContainer">
                <div class="formWrapper">
                    <div class="form-group">
                        <label for="txtUName">Username</label>
                        <asp:TextBox class="form-control" ID="txtUName" runat="server" Required="true"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtPass">Password</label>
                        <asp:TextBox class="form-control" ID="txtPass" TextMode="Password" runat="server" Required="true"></asp:TextBox>
                    </div>
                </div>
                <span id="errorContainer" runat="server"></span>
                <asp:Button class="btn btn-primary formWrapper" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>

