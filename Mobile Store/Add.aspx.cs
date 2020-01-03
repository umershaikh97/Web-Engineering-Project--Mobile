using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobile_Store
{
    public partial class Add : System.Web.UI.Page
    {
        private SqlConnection xConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            xConn = new SqlConnection("Server=.; DataBase=Mobile_Database; Trusted_Connection=True;");
            xConn.Open();
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            xConn = new SqlConnection("Server=.; DataBase=Mobile_Database; Trusted_Connection=True;");
            xConn.Open();

            int Price = Int32.Parse(txtPrice.Text);
            new SqlCommand("Insert into tblRecords values ('" + txtName.Text + "', '" + txtPhone.Text + "','" + txtMobNo.Text + "', '" + Price + "', '" + txtModel.Text + "', '" + txtBt.Text + "', '" + txtFm.Text + "', '" + txtCamera.Text + "', '" + TxtWifi.Text + "', 'NO') ", xConn).ExecuteNonQuery();


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
    }
}