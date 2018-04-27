using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CitizentManagerment
{
    public partial class ucLicenseDrive : UserControl
    {
        public ucLicenseDrive()
        {
            InitializeComponent();
        }
        
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "select * from LICENSEDRIVE";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucLicenseDrive_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtLDC.Text.Length == 0)
                MessageBox.Show("Not be empty license drive code");
            else
                if (txtLDN.Text.Length == 0)
                    MessageBox.Show("Not be empty license drive name");
                else
                    if (txtLDT.Text.Length == 0)
                        MessageBox.Show("Not be empty license drive terminable");
                    else
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("ADDLD", con);// "ADDCZ" : Ten store procedure  trong csdl
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@LDCODE", txtLDC.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@LDNAME", txtLDN.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@LDTM", txtLDT.Text.Trim()));              
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Add succesfully", "------REPORT------");
                            cmd.Dispose();
                            ketnoicsdl();
                        }
                        catch
                        {
                            MessageBox.Show("Can not be added !", "---------ERROR--------");
                        }
                        finally
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Close();
                        }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtLDC.Text.Length == 0)
                MessageBox.Show("Not be empty license drive code");
            else
                if (txtLDN.Text.Length == 0)
                    MessageBox.Show("Not be empty license drive name");
                else
                    if (txtLDT.Text.Length == 0)
                        MessageBox.Show("Not be empty license drive terminable");
                    else
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("EDITLD", con);// "ADDCZ" : Ten store procedure  trong csdl
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@LDCODE", txtLDC.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@LDNAME", txtLDN.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@LDTM", txtLDT.Text.Trim()));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Edit succesfully", "------REPORT------");
                            cmd.Dispose();
                            ketnoicsdl();
                        }
                        catch
                        {
                            MessageBox.Show("Can not be editted !", "---------ERROR--------");
                        }
                        finally
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Close();
                        }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtLDC.Text.Length == 0)
                MessageBox.Show("Not be empty license drive code");       
                    else
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELLD", con);// "ADDCZ" : Ten store procedure  trong csdl
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@LDCODE", txtLDC.Text.Trim()));                           
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("delete succesfully", "------REPORT------");
                            cmd.Dispose();
                            ketnoicsdl();
                        }
                        catch
                        {
                            MessageBox.Show("Can not be delete !", "---------ERROR--------");
                        }
                        finally
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Close();
                        }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtLDC.Text = "";
            txtLDN.Text = "";
            txtLDT.Text = "";
            txtLDC.Enabled=true;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtLDC.Text = gridView1.GetFocusedRowCellDisplayText("LDCODE");
            txtLDN.Text = gridView1.GetFocusedRowCellDisplayText("LDNAME");
            txtLDT.Text = gridView1.GetFocusedRowCellDisplayText("LDTERMINABLE");
            txtLDC.Enabled = false;

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                if (txtSearch.Text.Length != 0)
                {                    
                    string sql = " SELECT * FROM LICENSEDRIVE WHERE LDCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR LDNAME LIKE '%" + txtSearch.Text.Trim() + "%'";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                else
                {
                    string sql = " SELECT * FROM LICENSEDRIVE";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                //txtLDC.DataBindings.Clear();
                //txtLDN.DataBindings.Clear();
                //txtLDT.DataBindings.Clear();
                
                ////
                //txtLDC.DataBindings.Add("Text", gridControl1.DataSource, "LDCODE");
                //txtLDN.DataBindings.Add("Text", gridControl1.DataSource, "LDNAME");
                //txtLDT.DataBindings.Add("Text", gridControl1.DataSource, "LDTERMINABLE");               
            }
            catch
            {
                MessageBox.Show("Not found :( ", "--------REPORT--------");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Close();

            }
        }

      
    
    }
}
