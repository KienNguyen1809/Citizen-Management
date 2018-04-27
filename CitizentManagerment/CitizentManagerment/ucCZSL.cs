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
    public partial class ucCZSL : UserControl
    {
        public ucCZSL()
        {
            InitializeComponent();
        }

        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "select * from CZ_SL";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucCZSL_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.txtCC.Text.Length == 0)
                MessageBox.Show("Not be empty citizen code");
            else
                if (this.txtSC.Text.Length == 0)
                    MessageBox.Show("Not be empty salary code");
                else                  
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("ADDCZSL", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@SLCODE", txtSC.Text.Trim()));
                              
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Add successfully", "------REPORT------");
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
            if (this.txtCC.Text.Length == 0)
                MessageBox.Show("Not be empty citizen code");
            else
                if (this.txtSC.Text.Length == 0)
                    MessageBox.Show("Not be empty salary code");
                else                  
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("EDITCZSL", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@SLCODE", txtSC.Text.Trim()));                             
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Edit successfully", "------REPORT------");
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
            if (this.txtCC.Text.Length == 0)
                MessageBox.Show("Not be empty citizen code");
            else               
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("DELCZSL", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));                              
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Delete successfully", "------REPORT------");
                                cmd.Dispose();
                                ketnoicsdl();
                            }
                            catch
                            {
                                MessageBox.Show("Can not be deleted !", "---------ERROR--------");
                            }
                            finally
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Close();
                            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtCC.Text = "";
            txtSC.Text = "";           
            txtCC.Enabled = true;
            txtSC.Enabled = true;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtCC.Text = gridView1.GetFocusedRowCellDisplayText("CZCODE");
            txtSC.Text = gridView1.GetFocusedRowCellDisplayText("SLCODE");          
            txtCC.Enabled = false;
            txtSC.Enabled = false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                if (txtSearch.Text.Length != 0)
                {                   
                    string sql = " SELECT * FROM CZ_SL WHERE CZCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR SLCODE LIKE '%" + txtSearch.Text.Trim() + "%'";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                else
                {
                    string sql = " SELECT * FROM CZ_SL ";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
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

        public string numberofsalary()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("STATISTIC8", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@TUKHOA", txtStatistical.Text));
            SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
            com.Parameters.Add(resultParam);
            resultParam.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            string numberofsalary = com.Parameters["@Result"].Value.ToString();
            con.Close();
            return numberofsalary;
        }
        private void btStatistical_Click(object sender, EventArgs e)
        {
            txtStatis.Text = numberofsalary();
        }
    }
}
