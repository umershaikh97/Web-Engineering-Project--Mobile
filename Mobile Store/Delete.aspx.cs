using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobile_Store
{
    public partial class Delete : System.Web.UI.Page
    {
        private SqlConnection xConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            xConn = new SqlConnection("Server=.; DataBase=Mobile_Database; Trusted_Connection=True;");
            xConn.Open();
            customerRecordHeading.InnerHtml = "";
            DataTable xTable = new DataTable();
            new SqlDataAdapter("Select MID, CustomerName, PhoneNo, MobileName, Price, ModelNo, Bluetooth, FMRadio,Camera, WiFi from tblRecords where isDeleted = 'NO'", xConn).Fill(xTable);
            if (xTable.Rows.Count > 0)
            {
                xGrid.DataSource = xTable;
                xGrid.DataBind();
            }
            else
            {
                customerRecordHeading.InnerHtml = "No Records Available!";
            }
            xConn.Close();
        }

        protected void xGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            xConn.Open();
            int MID = Int32.Parse(txtMID.Text);


            DataTable xTable = new DataTable();
            new SqlCommand("Update tblRecords set isDeleted = 'YES' where MID='" + txtMID.Text + "'", xConn).ExecuteNonQuery();
            new SqlDataAdapter("Select MID, CustomerName, PhoneNo, MobileName, Price, ModelNo, Bluetooth, FMRadio,Camera, WiFi from tblRecords where isDeleted = 'NO'", xConn).Fill(xTable);
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
            xConn.Close();
        }
    }
}