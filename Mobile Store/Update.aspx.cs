using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobile_Store
{
    public partial class Update : System.Web.UI.Page
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            xConn = new SqlConnection("Server=.; DataBase=Mobile_Database; Trusted_Connection=True;");
            xConn.Open();

            int Price = Int32.Parse(txtPrice.Text);
            new SqlCommand("Update tblRecords set CustomerName = '" + txtName.Text + "' , PhoneNo = '" + txtPhone.Text + "' , MobileName = '" + txtMobNo.Text + "' , Price = '" + Price + "' , ModelNo = '" + txtModel.Text + "' , Bluetooth = '" + txtBt.Text + "' , FMRadio = '" + txtFm.Text + "' , Camera = '" + txtCamera.Text + "' , WiFi = '" + TxtWifi.Text + "' , isDeleted='NO' where MID='" + txtMID.Text + "'", xConn).ExecuteNonQuery();

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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            xConn.Open();
            int MID = Int32.Parse(txtMID.Text);
            DataTable xTable = new DataTable();
            new SqlDataAdapter("Select CustomerName, PhoneNo, MobileName, Price, ModelNo, Bluetooth, FMRadio,Camera, WiFi from tblRecords where MID='" + txtMID.Text + "' and isDeleted = 'NO'", xConn).Fill(xTable);
            if (xTable.Rows.Count > 0)
            {
                txtName.Text = xTable.Rows[0][0].ToString();
                txtPhone.Text = xTable.Rows[0][1].ToString();
                txtMobNo.Text = xTable.Rows[0][2].ToString();
                txtPrice.Text = xTable.Rows[0][3].ToString();
                txtModel.Text = xTable.Rows[0][4].ToString();
                txtBt.Text = xTable.Rows[0][5].ToString();
                txtFm.Text = xTable.Rows[0][6].ToString();
                txtCamera.Text = xTable.Rows[0][7].ToString();
                TxtWifi.Text = xTable.Rows[0][8].ToString();
            }
        }
    }
}
