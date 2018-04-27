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
    public partial class ucCZPP : UserControl
    {
        public ucCZPP()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                string sql = "select * from CZ_PP";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridControl1.DataSource = dt;
        }
        private void ucCZPP_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.txtPC.Text.Length == 0)
                MessageBox.Show("Not be empty passport code");
            else
                if (this.txtCC.Text.Length == 0)
                    MessageBox.Show("Not be empty citizen code");
                else                  
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("ADDCZPP", con);// "ADDCZ" : Ten store procedure  trong csdl
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@PPCODE", txtPC.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@PPSTARTIME", dtPST.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@PPENDTIME", dtPET.Text.Trim()));
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
            if (this.txtPC.Text.Length == 0)
                MessageBox.Show("Not be empty passport code");
            else
                if (this.txtCC.Text.Length == 0)
                    MessageBox.Show("Not be empty citizen code");
                else                   
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("EDITCZPP", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@PPCODE", txtPC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@PPSTARTIME", dtPST.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@PPENDTIME", dtPET.Text.Trim()));
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
            if (this.txtPC.Text.Length == 0)
                MessageBox.Show("Not be empty passport code");           
                        else
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("DELCZPP", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@PPCODE", txtPC.Text.Trim()));                             
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
            txtPC.Text = "";
            txtCC.Text = "";
            dtPST.Text = "";
            dtPET.Text = "";
            txtPC.Enabled = true;
            txtCC.Enabled = true;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtCC.Text = gridView1.GetFocusedRowCellDisplayText("CZCODE");
            txtPC.Text = gridView1.GetFocusedRowCellDisplayText("PPCODE");
            dtPST.Text = gridView1.GetFocusedRowCellDisplayText("PPSTARTIME");
            dtPET.Text = gridView1.GetFocusedRowCellDisplayText("PPENDTIME");
            txtPC.Enabled = false;
            txtCC.Enabled = false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                if (txtSearch.Text.Length != 0)
                {

                    string sql = " SELECT * FROM CZ_PP WHERE CZCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR PPCODE LIKE '%" + txtSearch.Text.Trim() + "%'";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                else
                {
                    string sql = " SELECT * FROM CZ_PP WHERE ";
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

        public string numberofpassport()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("STATISTIC9", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@KW", txtStatistical.Text));
            SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
            com.Parameters.Add(resultParam);
            resultParam.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            string numberofpassport = com.Parameters["@Result"].Value.ToString();
            con.Close();
            return numberofpassport;
        }
        private void btStatistical_Click(object sender, EventArgs e)
        {
            txtStatis.Text = numberofpassport();
        }
    }
}
