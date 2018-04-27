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
    public partial class ucSalary : UserControl
    {
        public ucSalary()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "SELECT * FROM SALARY";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.txtSC.Text.Length == 0)
                MessageBox.Show("Not be empty salary code");
            else
                if (this.txtSN.Text.Length == 0)
                    MessageBox.Show("Not be empty salary name");
                else
                    if (this.txtMoney.Text.Length == 0)
                        MessageBox.Show("Not be empty money");                   
                        else
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("ADDSL", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@SLCODE", txtSC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@SLNAME", txtSN.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@SLMONEY", txtMoney.Text.Trim()));                              
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Add successfully", "------REPORT------");
                                cmd.Dispose();
                                ketnoicsdl();
                            }
                            catch
                            {
                                MessageBox.Show("Can not be add !", "---------ERROR--------");
                            }
                            finally
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Close();
                            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (this.txtSC.Text.Length == 0)
                MessageBox.Show("Not be empty salary code");
            else
                if (this.txtSN.Text.Length == 0)
                    MessageBox.Show("Not be empty salary name");
                else
                    if (this.txtMoney.Text.Length == 0)
                        MessageBox.Show("Not be empty money");
                    else
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("EDITSL", con);// "ADDCZ" : Ten store procedure  trong csdl
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@SLCODE", txtSC.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@SLNAME", txtSN.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@SLMONEY", txtMoney.Text.Trim()));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Edit successfully", "------REPORT------");
                            cmd.Dispose();
                            ketnoicsdl();
                        }
                        catch
                        {
                            MessageBox.Show("Can not be edit !", "---------ERROR--------");
                        }
                        finally
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Close();
                        }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (this.txtSC.Text.Length == 0)
                MessageBox.Show("Not be empty salary code");
            else
                try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELSL", con);// "ADDCZ" : Ten store procedure  trong csdl
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@SLCODE", txtSC.Text.Trim()));                           
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Delete successfully", "------REPORT------");
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
            txtSC.Text = "";
            txtSN.Text = "";
            txtMoney.Text = "";
            txtSearch.Text = "";
            txtSC.Enabled = true;
        }

        private void ucSalary_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            txtSC.Enabled = false;
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
                    string sql = " SELECT * FROM SALARY WHERE SLCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR SLNAME LIKE '%" + txtSearch.Text.Trim() + "%'";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                else
                {
                    MessageBox.Show("Please enter your infomation again!", "--------REPORT----------");
                }                
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
