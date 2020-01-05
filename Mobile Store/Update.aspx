<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Mobile_Store.Update" %>

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
                                    <h3 id="H1" runat="server" class="display-4 headingMain">Update Record</h3>
                    <div class="loginContainerAdd">
                <div class="formWrapperAdd">
                                        <div class="form-group formgroupAdd">
                        <label for="txtMID">MID</label>
                        <asp:TextBox class="form-control" ID="txtMID" runat="server" Required="true"></asp:TextBox>
                    </div>
                                   <div class="form-group formgroupAdd sBtn">
                <asp:Button class="btn btn-primary formWrapperAdd sBtn" ID="searchBtnn" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </div>
                    <div class="form-group formgroupAdd">
                        <label for="txtName">Customer Name</label>
                        <asp:TextBox class="form-control" ID="txtName" runat="server" ></asp:TextBox>
                    </div>
                    <div class="form-group formgroupAdd">
                        <label for="txtPhone">Phone no.</label>
                        <asp:TextBox class="form-control" ID="txtPhone" runat="server"></asp:TextBox>
                    </div>
                                        <div class="form-group formgroupAdd">
                        <label for="txtPhone">Mobile Name</label>
                        <asp:TextBox class="form-control" ID="txtMobNo" runat="server" ></asp:TextBox>
                    </div>
                                                     <div class="form-group formgroupAdd">
                        <label for="txtPhone">Price</label>
                        <asp:TextBox class="form-control" ID="txtPrice" runat="server" ></asp:TextBox>
                    </div>
                                         <div class="form-group formgroupAdd">
                        <label for="txtPhone">Model Name</label>
                        <asp:TextBox class="form-control" ID="txtModel" runat="server" ></asp:TextBox>
                    </div>

                                                     <div class="form-group formgroupAdd">
                        <label for="txtPhone">Bluetooth</label>
                        <asp:TextBox class="form-control" ID="txtBt" runat="server" ></asp:TextBox>
                    </div>
                                                         <div class="form-group formgroupAdd">
                        <label for="txtPhone">FM Radio</label>
                        <asp:TextBox class="form-control" ID="txtFm" runat="server" ></asp:TextBox>
                    </div>
                                                     <div class="form-group formgroupAdd">
                        <label for="txtPhone">Camera</label>
                        <asp:TextBox class="form-control" ID="txtCamera" runat="server"></asp:TextBox>
                    </div>
                                                     <div class="form-group formgroupAdd">
                        <label for="txtPhone">WiFi</label>
                        <asp:TextBox class="form-control" ID="TxtWifi" runat="server" ></asp:TextBox>
                    </div>
                </div>
                <span id="errorContainer" runat="server"></span>
                <asp:Button class="btn btn-primary formWrapperAdd addBtn" ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
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
