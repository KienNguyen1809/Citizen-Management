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
    public partial class ucFamilyRegister : UserControl
    {
        public ucFamilyRegister()
        {
            InitializeComponent();
        }
        
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "select * from FAMILYREGISTER";
            SqlCommand com= new SqlCommand(sql,con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;           
        }

        private void ucFamilyRegister_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.txtFRC.Text.Length == 0)
                MessageBox.Show("Not be empty family register code");
            else
                if (this.txtFRN.Text.Length == 0)
                    MessageBox.Show("Not be empty family register name");
                else
                    if (this.txtN.Text.Length == 0)
                        MessageBox.Show("Not be empty NUMMEMBER");
                    else
                        if (this.txtAC.Text.Length == 0)
                            MessageBox.Show("Not be empty location are");
                        else
                                try
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("ADDFR", con);// "ADDCZ" : Ten store procedure  trong csdl
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add(new SqlParameter("@FRCODE", txtFRC.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@FRNAME", txtFRN.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@NUMMENBER", txtN.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@ARCODE", txtAC.Text.Trim()));                                   
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
            if (this.txtFRC.Text.Length == 0)
                MessageBox.Show("Not be empty location code");
            else
                if (this.txtFRN.Text.Length == 0)
                    MessageBox.Show("Not be empty location name");
                else
                    if (this.txtN.Text.Length == 0)
                        MessageBox.Show("Not be empty location population");
                    else
                        if (this.txtAC.Text.Length == 0)
                            MessageBox.Show("Not be empty location are");
                        else
                            try
                            {
                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("EDITFR", con);// "ADDCZ" : Ten store procedure  trong csdl
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@FRCODE", txtFRC.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@FRNAME", txtFRN.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@NUMMEMBER", txtN.Text.Trim()));
                                cmd.Parameters.Add(new SqlParameter("@ARCODE", txtAC.Text.Trim()));
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
  

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtFRC.Text = "";
            txtFRN.Text = "";
            txtN.Text = "";
            txtAC.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtFRC.Text = gridView1.GetFocusedRowCellDisplayText("FRCODE");
            txtFRN.Text = gridView1.GetFocusedRowCellDisplayText("FRNAME");
            txtN.Text = gridView1.GetFocusedRowCellDisplayText("NUMMEMBER");
            txtAC.Text = gridView1.GetFocusedRowCellDisplayText("ARCODE");
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                if (txtSearch.Text.Length != 0)
                {                 
                    string sql = " SELECT * FROM FAMILYREGISTER WHERE FRCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR FRNAME LIKE '%" + txtSearch.Text.Trim() + "%'";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                else
                {
                    string sql = " SELECT * FROM FAMILYREGISTER";
                    SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                    SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                    DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                    sda.Fill(dt1);
                    gridControl1.DataSource = dt1;
                }
                txtFRC.DataBindings.Clear();
                txtFRN.DataBindings.Clear();
                txtN.DataBindings.Clear();
                txtAC.DataBindings.Clear();
                //
                txtFRC.DataBindings.Add("Text", gridControl1.DataSource, "FRCODE");
                txtFRN.DataBindings.Add("Text", gridControl1.DataSource, "FRNAME");
                txtN.DataBindings.Add("Text", gridControl1.DataSource, "NUMMEMBER");
                txtAC.DataBindings.Add("Text", gridControl1.DataSource, "ARCODE");
            }
            catch(Exception)
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
