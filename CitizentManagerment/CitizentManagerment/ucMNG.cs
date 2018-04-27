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
    public partial class ucMNG : UserControl
    {
        public ucMNG()
        {
            InitializeComponent();
        }
        private void ucMNG_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            dtBirth.Properties.EditMask = "MM/dd/yyyy";
            dtBirth.Properties.Mask.UseMaskAsDisplayFormat = true;
            dtBirth.Properties.CharacterCasing = CharacterCasing.Upper;
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "  select * from MANAGER";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtMC.Text.Length == 0)
                MessageBox.Show("Not be empty manager code");
            else
                if (this.txtMN.Text.Length == 0)
                    MessageBox.Show("Not be empty manager name");
                else
                    if (this.cbSex.Text.Length == 0)
                        MessageBox.Show("Not be empty manager sex ");
                    else
                        if (this.dtBirth.Text.Length == 0)
                            MessageBox.Show("Not be empty manager birth");
                        else
                            if (this.txtHT.Text.Length == 0)
                                MessageBox.Show("Not be empty home town");
                            else
                                if (this.txtPosition.Text.Length == 0)
                                    MessageBox.Show("Not be empty position");
                                else
                                    if (this.txtAC.Text.Length == 0)
                                        MessageBox.Show("Not be empty admin code");
                                    else
                                        if (this.txtMNP.Text.Length == 0)
                                            MessageBox.Show("Not be empty manager password");
                                        else
                                            if (this.txtARC.Text.Length == 0)
                                                MessageBox.Show("Not be empty area code");
                                            else
                                            try
                                            {
                                                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                                con.Open();
                                                SqlCommand cmd = new SqlCommand("ADDMN", con);// "ADDCZ" : Ten store procedure  trong csdl
                                                cmd.CommandType = CommandType.StoredProcedure;
                                                cmd.Parameters.Add(new SqlParameter("@MNCODE", txtMC.Text.Trim()));
                                                cmd.Parameters.Add(new SqlParameter("@MNNAME", txtMN.Text.Trim()));
                                                cmd.Parameters.Add(new SqlParameter("@SEX", cbSex.Text.Trim()));
                                                cmd.Parameters.Add(new SqlParameter("@BIRTH", dtBirth.EditValue));
                                                cmd.Parameters.Add(new SqlParameter("@HOMETOWN", txtHT.Text.Trim()));
                                                cmd.Parameters.Add(new SqlParameter("@MNPOSITION", txtPosition.Text.Trim()));
                                                cmd.Parameters.Add(new SqlParameter("@MNPASSWORD", txtMNP.Text.Trim()));
                                                cmd.Parameters.Add(new SqlParameter("@ADMINCODE", txtAC.Text.Trim()));
                                                cmd.Parameters.Add(new SqlParameter("@ARCODE", txtARC.Text.Trim()));;
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
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
             if (this.txtMC.Text.Length == 0)
                MessageBox.Show("Not be empty manager code");
            else
                if (this.txtMN.Text.Length == 0)
                    MessageBox.Show("Not be empty manager name");
                else
                    if (this.cbSex.Text.Length == 0)
                        MessageBox.Show("Not be empty manager sex ");
                    else
                        if (this.dtBirth.Text.Length == 0)
                            MessageBox.Show("Not be empty manager birth");
                        else
                            if (this.txtHT.Text.Length == 0)
                                MessageBox.Show("Not be empty home town");
                            else
                                if (this.txtPosition.Text.Length == 0)
                                    MessageBox.Show("Not be empty position");
                                else
                                    if (this.txtAC.Text.Length == 0)
                                        MessageBox.Show("Not be empty admin code");
                                    else
                                        if (this.txtPosition.Text.Length == 0)
                                            MessageBox.Show("Not be empty position");
                                        else
                                            if (this.txtMNP.Text.Length == 0)
                                                MessageBox.Show("Not be empty manager password");
                                            else
                                                if (this.txtARC.Text.Length == 0)
                                                    MessageBox.Show("Not be empty area code");
                                                else
                                                try
                                                {
                                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                                    con.Open();
                                                    SqlCommand cmd = new SqlCommand("EDITMN", con);// "ADDCZ" : Ten store procedure  trong csdl
                                                    cmd.CommandType = CommandType.StoredProcedure;
                                                    cmd.Parameters.Add(new SqlParameter("@MNCODE", txtMC.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@MNNAME", txtMN.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@SEX", cbSex.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@BIRTH", dtBirth.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@HOMETOWN", txtHT.Text.Trim()));                                      
                                                    cmd.Parameters.Add(new SqlParameter("@MNPOSITION", txtPosition.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@MNPASSWORD", txtMNP.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@ADMINCODE", txtAC.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@ARCODE", txtARC.Text.Trim())); ;
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
             if (this.txtMC.Text.Length == 0)
                MessageBox.Show("Not be empty manager code");     
            else                                          
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELMN", con);// "ADDCZ" : Ten store procedure  trong csdl
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@MNCODE", txtMC.Text.Trim()));                 
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
            txtMC.Text = "";
            txtMN.Text = "";
            cbSex.Text = "";
            dtBirth.Text = "";
            txtPosition.Text = "";
            txtHT.Text = "";
            txtAC.Text = "";
            txtSearch.Text = "";
            cbSearch.Text = "";
            txtMC.Focus();
            txtMC.Enabled = true;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtMC.Text = gridView1.GetFocusedRowCellDisplayText("MNCODE");
            txtMN.Text = gridView1.GetFocusedRowCellDisplayText("MNNAME");
            cbSex.Text = gridView1.GetFocusedRowCellDisplayText("SEX");
            dtBirth.Text = gridView1.GetFocusedRowCellDisplayText("BIRTH");
            txtHT.Text = gridView1.GetFocusedRowCellDisplayText("HOMETOWN");
            txtPosition.Text = gridView1.GetFocusedRowCellDisplayText("MNPOSITION");
            txtAC.Text = gridView1.GetFocusedRowCellDisplayText("ADMINCODE");
            txtARC.Text = gridView1.GetFocusedRowCellDisplayText("ARCODE");
            txtMNP.Text = gridView1.GetFocusedRowCellDisplayText("MNPASSWORD");
            txtMC.Enabled = false;
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
                    //SqlCommand com = new SqlCommand("SEARCH", con);
                    //com.CommandType = CommandType.StoredProcedure;
                    //com.Parameters.Add(new SqlParameter("@KEYSEACRH",txtSearch.Text.Trim()));
                    //com.ExecuteNonQuery();
                    //com.Dispose();
                    //SqlDataAdapter da = new SqlDataAdapter(com);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //gridControl1.DataSource=dt;  

                    //
                    string sql = " SELECT * FROM MANAGER WHERE MNCODE LIKE '%" + txtSearch.Text.Trim() + "%' OR MNNAME LIKE '%" + txtSearch.Text.Trim() + "%'OR MNPOSITION LIKE '%" + txtSearch.Text.Trim() + "%'";
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
                txtMC.DataBindings.Clear();
                txtMN.DataBindings.Clear();
                txtHT.DataBindings.Clear();
                dtBirth.DataBindings.Clear();
                cbSex.DataBindings.Clear();
                txtPosition.DataBindings.Clear();
                txtAC.DataBindings.Clear();
                txtMNP.DataBindings.Clear();
                txtARC.DataBindings.Clear();
                //
                txtMC.DataBindings.Add("Text", gridControl1.DataSource, "MNCODE");
                txtMN.DataBindings.Add("Text", gridControl1.DataSource, "MNNAME");
                txtHT.DataBindings.Add("Text", gridControl1.DataSource, "HOMETOWN");
                dtBirth.DataBindings.Add("Text", gridControl1.DataSource, "BIRTH");
                cbSex.DataBindings.Add("Text", gridControl1.DataSource, "SEX");
                txtPosition.DataBindings.Add("Text", gridControl1.DataSource, "POSITION");
                txtAC.DataBindings.Add("Text", gridControl1.DataSource, "ADMINCODE");
                txtARC.DataBindings.Add("Text", gridControl1.DataSource, "ARCODE");
                txtMNP.DataBindings.Add("Text", gridControl1.DataSource, "MNPASSWORD");
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

