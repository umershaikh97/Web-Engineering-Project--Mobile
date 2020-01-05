<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Mobile_Store.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mobile Store</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" runat="server" media="screen" href="~/css/styles.css" />
</head>
<body>
        <div class="root_home">
<nav class="navbar navbar-expand-lg fixed-top navbar-dark bg-dark navbarCustom">
  <a class="navbar-brand" href="Home.aspx">Mobile Store</a>

    <ul class="navbar-nav">
              <li class="nav-item liCustom">
        <a class="nav-link" href="Home.aspx">Home</a>
      </li>
                      <li class="nav-item liCustom">
        <a class="nav-link" href="View.aspx">Find Record</a>
      </li>
      <li class="nav-item liCustom">
        <a class="nav-link" href="Add.aspx">Add Record</a>
      </li>
      <li class="nav-item liCustom">
        <a class="nav-link" href="Update.aspx">Update Record</a>
      </li>
              <li class="nav-item liCustom">
        <a class="nav-link" href="Delete.aspx">Delete Record</a>
      </li>
                      <li class="nav-item liCustom">
        <a class="nav-link" href="Login.aspx">Log out</a>
      </li>
    </ul>
</nav>
    </div>

    <form id="form1" runat="server">




        <center class="homeContent">  
                                                <h3 id="H1" runat="server" class="display-4 headingMain">Delete Record</h3>
                    <div class="loginContainerView">
                <div class="formWrapperView">
                    <div class="form-group formgroupView">
                        <label for="txtName">MID</label>
                        <asp:TextBox class="form-control" ID="txtMID" runat="server" Required="true"></asp:TextBox>
                    </div>
                </div>
                <span id="errorContainer" runat="server"></span>
                <asp:Button class="btn btn-primary formWrapperView searchBtn" ID="btnSearch" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </div>
                        <h3 id="customerRecordHeading" runat="server" class="display-4 headingMain"></h3>
        <asp:GridView CssClass="GridViewStyle" ID="xGrid" runat="server" OnSelectedIndexChanged="xGrid_SelectedIndexChanged" >
    <FooterStyle CssClass="GridViewFooterStyle" />
    <RowStyle CssClass="GridViewRowStyle" />   
    <SelectedRowStyle CssClass="GridViewSelectedRowStyle" />
    <PagerStyle CssClass="GridViewPagerStyle" />
    <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
    <HeaderStyle CssClass="GridViewHeaderStyle" />
</asp:GridView>
        </center>
    </form>
</body>
</html>