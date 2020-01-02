<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Mobile_Store.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mobile Store</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
    <table border="1" cellpadding="0" cellspacing="5" align="center">
   
   <tr>
   <td bgcolor="LightGreen">Username: </td>
   <td><asp:TextBox ID="txtUName" runat="server" Required></asp:TextBox></td>
   </tr>
   
   <tr>
   <td bgcolor="LightGreen">Password</td>
   <td><asp:TextBox ID="txtPass" TextMode="Password" runat="server" Required></asp:TextBox></td>
   </tr>

   <tr>

   <td colspan=2><asp:Button ID="btnLogin" runat="server" Text="Login" 
           onclick="btnLogin_Click" /></td>
   </tr>

   </table>  

    </div>
        </div>
    </form>
</body>
</html>

