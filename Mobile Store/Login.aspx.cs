﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobile_Store
{
    public partial class Login : System.Web.UI.Page
    {
        private SqlConnection xConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            xConn = new SqlConnection("Server=.; DataBase=Mobile_Database; Trusted_Connection=True;");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            new SqlDataAdapter("Select * from tblLogin where Username='" + txtUName.Text + "' and Password='" + txtPass.Text + "'", xConn).Fill(table);
            if (table.Rows.Count == 1)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
               errorContainer.Controls.Add(new LiteralControl("<p>Error logging in with provided credentials</p>"));
            }
        }
    }
}