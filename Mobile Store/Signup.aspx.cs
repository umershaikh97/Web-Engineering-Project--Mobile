using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobile_Store
{
    public partial class Signup : System.Web.UI.Page
    {
        private SqlConnection xConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            xConn = new SqlConnection("Server=.; DataBase=Mobile_Database; Trusted_Connection=True;");
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            xConn.Open();
            new SqlCommand("Insert into tblLogin values ('" + txtUName.Text + "', '" + txtPass.Text + "') ", xConn).ExecuteNonQuery();
            xConn.Close();
            Response.Redirect("Login.aspx");
        }
    }
}