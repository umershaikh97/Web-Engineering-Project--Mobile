using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobile_Store
{
    public partial class View : System.Web.UI.Page
    {
        private SqlConnection xConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            xConn = new SqlConnection("Server=.; DataBase=Mobile_Database; Trusted_Connection=True;");
            customerRecordHeading.InnerHtml = "";
        }

        protected void xGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            xConn.Open();
            DataTable xTable = new DataTable();
            new SqlDataAdapter("Select MID, CustomerName, PhoneNo, MobileName, Price, ModelNo, Bluetooth, FMRadio,Camera, WiFi from tblRecords where CustomerName='" + txtName.Text + "' and PhoneNo='" + txtPhone.Text + "' and isDeleted = 'NO'", xConn).Fill(xTable);
            if (xTable.Rows.Count > 0)
            {
                customerRecordHeading.InnerHtml = "";
                xGrid.DataSource = xTable;
                xGrid.DataBind();
            }
            else
            {
                xTable = null;
                customerRecordHeading.InnerHtml = "No Record Found!";
            }
        }
    }
}