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
    public partial class ucCZIS : UserControl
    {
        public ucCZIS()
        {
            InitializeComponent();
            
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "select * from CZ_IS";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                if (txtSearch.Text.Length != 0)
                {                    
                    string sql = " SELECT * FROM CZ_IS WHERE CZCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR ISCODE LIKE '%" + txtSearch.Text.Trim() + "%'";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                else
                {
                    string sql = " SELECT * FROM CZ_IS WHERE CZCODE";
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

        private void ucCZIS_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.txtIC.Text.Length == 0)
                MessageBox.Show("Not be empty insurance code");
            else
                if (this.txtCC.Text.Length == 0)
                    MessageBox.Show("Not be empty citizen code");
                else                   
                                try
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("ADDSCIS", con);// "ADDCZ" : Ten store procedure  trong csdl
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add(new SqlParameter("@ISCODE", txtIC.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@ISSTARTIME", txtIST.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@ISENDTIME", txtIET.Text.Trim()));                                   
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
                                    SqlConnection con = new SqlConnection(@"DData Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                    con.Close();
                                }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (this.txtIC.Text.Length == 0)
                MessageBox.Show("Not be empty insurance code");
            else
                if (this.txtCC.Text.Length == 0)
                    MessageBox.Show("Not be empty citizen code");
                else                                        
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("EDITSCIS", con);// "ADDCZ" : Ten store procedure  trong csdl
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ISCODE", txtIC.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@ISSTARTIME", txtIST.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@ISENDTIME", txtIET.Text.Trim()));
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
            if (this.txtIC.Text.Length == 0)
                MessageBox.Show("Not be empty insurance code");
            else
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELSCIS", con);// "ADDCZ" : Ten store procedure  trong csdl
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ISCODE", txtIC.Text.Trim()));                           
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
            txtCC.Text = "";
            txtIC.Text = "";
            txtIST.Text = "";
            txtIET.Text = "";
            txtIC.Enabled = true;
            txtCC.Enabled = true;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtIC.Text = gridView1.GetFocusedRowCellDisplayText("ISCODE");
            txtCC.Text = gridView1.GetFocusedRowCellDisplayText("CZCODE");
            txtIST.Text = gridView1.GetFocusedRowCellDisplayText("ISSTARTIME");
            txtIET.Text = gridView1.GetFocusedRowCellDisplayText("ISENDTIME");
            txtIC.Enabled = false;
            txtCC.Enabled = false;
        }


        public string numberofinsurance()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("STATISTIC6", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@KW", txtStatis.Text));
            SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
            com.Parameters.Add(resultParam);
            resultParam.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            string numberofinsurance = com.Parameters["@Result"].Value.ToString();
            con.Close();
            return numberofinsurance;
        }
        private void btStatis_Click(object sender, EventArgs e)
        {
            if (this.cbStatis.Text.Length == 0)
                MessageBox.Show("Please select the type of statistics");
            else
                if (this.cbStatis.Text == "Insurance Code")
                    txtNOIC.Text = numberofinsurance();
        }
    }
}
