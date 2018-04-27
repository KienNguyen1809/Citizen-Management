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
    public partial class ucInsurance : UserControl
    {
        public ucInsurance()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "select * from INSURANCE";
            SqlCommand com = new SqlCommand(sql,con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void ucInsurance_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            txtIC.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.txtIC.Text.Length == 0)
                MessageBox.Show("Not be empty insurance code");
            else
                if (this.txtIN.Text.Length == 0)
                    MessageBox.Show("Not be empty insurance name");
                else
                    if (this.txtPrice.Text.Length == 0)
                        MessageBox.Show("Not be empty price");
                    else
                        if (this.txtIT.Text.Length == 0)
                            MessageBox.Show("Not be empty insurance terminable");
                        else
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("ADDIS", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@ISCODE", txtIC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@ISNAME", txtIN.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@PRICE", txtPrice.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@ISTERMINABLE", txtIT.Text.Trim()));
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
            if (this.txtIC.Text.Length == 0)
                MessageBox.Show("Not be empty insurance code");
            else
                if (this.txtIN.Text.Length == 0)
                    MessageBox.Show("Not be empty insurance name");
                else
                    if (this.txtPrice.Text.Length == 0)
                        MessageBox.Show("Not be empty price");
                    else
                        if (this.txtIT.Text.Length == 0)
                            MessageBox.Show("Not be empty insurance terminable");
                        else
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("EDITIS", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@ISCODE", txtIC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@ISNAME", txtIN.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@PRICE", txtPrice.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@ISTERMINABLE", txtIT.Text.Trim()));
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
                if (this.txtIC.Text.Length == 0)
                MessageBox.Show("Not be empty insurance code");          
                    else
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELIS", con);// "ADDCZ" : Ten store procedure  trong csdl
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@ISCODE", txtIC.Text.Trim()));                         
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
            txtIC.Text = "";
            txtIN.Text = "";
            txtPrice.Text = "";
            txtIT.Text = "";
            txtIC.Focus();
            txtIC.Enabled = true;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtIC.Text = gridView1.GetFocusedRowCellDisplayText("ISCODE");
            txtIN.Text = gridView1.GetFocusedRowCellDisplayText("ISNAME");
            txtPrice.Text = gridView1.GetFocusedRowCellDisplayText("PRICE");
            txtIT.Text = gridView1.GetFocusedRowCellDisplayText("ISTERMINABLE");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                if (txtSearch.Text.Length != 0)
                {                   
                    string sql = " SELECT * FROM INSURANCE WHERE ISCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR ISNAME LIKE '%" + txtSearch.Text.Trim() + "%'";
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
                txtIC.DataBindings.Clear();
                txtIN.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtIT.DataBindings.Clear();
                //
                txtIC.DataBindings.Add("Text", gridControl1.DataSource, "ISCODE");
                txtIN.DataBindings.Add("Text", gridControl1.DataSource, "ISNAME");
                txtPrice.DataBindings.Add("Text", gridControl1.DataSource, "PRICE");
                txtIT.DataBindings.Add("Text", gridControl1.DataSource, "ISTERMINABLE");
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
