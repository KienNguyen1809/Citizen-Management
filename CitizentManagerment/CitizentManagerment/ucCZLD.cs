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
    public partial class ucCZLD : UserControl
    {
        public ucCZLD()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "select * from CZ_LD";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void ucCZLD_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtCC.Text.Length == 0)
                MessageBox.Show(" Not be empty citizen code");
            else
                if (txtLDC.Text.Length == 0)
                    MessageBox.Show(" Not be empty license drive code");
                else               
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("ADDCZLD", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@CZCODE",txtCC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@LDCODE",txtLDC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@LDSTARTIME", txtLDST.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@LDENDTIME", txtLDET.Text.Trim()));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Add succesfully", "----------REPORT---------");
                                cmd.Dispose();
                                ketnoicsdl();
                            }
                            catch(Exception)
                            {
                                MessageBox.Show("Can not be added","-----------ERROR---------");
                            }
                            finally
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Close();
                            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtCC.Text.Length == 0)
                MessageBox.Show(" Not be empty citizen code");
            else
                if (txtLDC.Text.Length == 0)
                    MessageBox.Show(" Not be empty license drive code");                  
                        else
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("EDITCZLD", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@LDCODE", txtLDC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@LDSTARTIME", txtLDST.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@LDENDTIME", txtLDET.Text.Trim()));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Edit succesfully", "----------REPORT---------");
                                cmd.Dispose();
                                ketnoicsdl();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Can not be Editted", "-----------ERROR---------");
                            }
                            finally
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Close();
                            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtCC.Text.Length == 0)
                MessageBox.Show(" Not be empty citizen code");          
            else
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELCZLD", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));                 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete succesfully", "----------REPORT---------");
                    cmd.Dispose();
                    ketnoicsdl();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not deleted", "-----------ERROR---------");
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
            txtLDC.Text = "";
            txtLDST.Text = "";
            txtLDET.Text = "";
            txtCC.Focus();
            txtCC.Enabled = true;
            txtLDC.Enabled = true;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtCC.Text = gridView1.GetFocusedRowCellDisplayText("CZCODE");
            txtLDC.Text = gridView1.GetFocusedRowCellDisplayText("LDCODE");
            txtLDST.Text = gridView1.GetFocusedRowCellDisplayText("LDSTARTIME");
            txtLDET.Text = gridView1.GetFocusedRowCellDisplayText("LDENDTIME");
            txtCC.Enabled = false;
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
                    string sql = " SELECT * FROM CZ_LD WHERE CZCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR LDCODE LIKE '%" + txtSearch.Text.Trim() + "%'";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                else
                {
                    string sql = " SELECT * FROM CZ_LD ";
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

        public string numberoflicensedrive()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("STATISTIC7", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@TUKHOA", txtStatis.Text));
            SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
            com.Parameters.Add(resultParam);
            resultParam.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            string numberlicensedrive = com.Parameters["@Result"].Value.ToString();
            con.Close();
            return numberlicensedrive;
        }
        private void btStatis_Click(object sender, EventArgs e)
        {
            if (this.cbStatis.Text.Length == 0)
                MessageBox.Show("Please select the type of statistics");
            else
                if (this.cbStatis.Text == "License Drive Code")
                    txtNOLD.Text = numberoflicensedrive();
        }

   
    }
}
