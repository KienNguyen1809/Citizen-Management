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
    public partial class ucCITIZEN : UserControl
    {
        public ucCITIZEN()
        {
            InitializeComponent();
        }

        private void ucCITIZEN_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            LOADCOMBOBOX();     
           
            //dtBirth.Properties.EditMask = "MM/dd/yyyy";
            //dtBirth.Properties.Mask.UseMaskAsDisplayFormat = true;
            //dtBirth.Properties.CharacterCasing = CharacterCasing.Upper;
        }

        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "select * from CITIZEN";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.txtCC.Text.Length == 0)
                MessageBox.Show("Not be empty citizen code");
            else
                if (this.txtCN.Text.Length == 0)          
                    MessageBox.Show("Not be empty citizen name");
                else
                    if (this.cbSex.Text.Length == 0)
                        MessageBox.Show("Not be empty citizen sex ");
                    else
                        if (this.dtBirth.Text.Length == 0)
                            MessageBox.Show("Not be empty citizen birth");
                        else
                            if (this.txtAdress.Text.Length == 0)
                                MessageBox.Show("Not be empty citizen address");
                            else                            
                                        if (this.txtPosition.Text.Length == 0)
                                            MessageBox.Show("Not be empty position");
                                        else
                                            if (this.comboBox1.Text.Length == 0)
                                                MessageBox.Show("Not be empty family register");
                                            else
                                                try 
                                                {
                                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                                    con.Open();
                                                    SqlCommand cmd = new SqlCommand("ADDCZ", con);// "ADDCZ" : Ten store procedure  trong csdl
                                                    cmd.CommandType = CommandType.StoredProcedure;
                                                    cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@CZNAME", txtCN.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@CZSEX", cbSex.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@CZBIRTH", dtBirth.EditValue));
                                                    cmd.Parameters.Add(new SqlParameter("@CZADRESS", txtAdress.Text.Trim()));
                    
                                                    cmd.Parameters.Add(new SqlParameter("@POSITION", txtPosition.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@FRCODE", comboBox1.Text.Trim()));
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

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtCC.Text = gridView1.GetFocusedRowCellDisplayText("CZCODE");
            txtCN.Text = gridView1.GetFocusedRowCellDisplayText("CZNAME");
            dtBirth.Text = gridView1.GetFocusedRowCellDisplayText("CZBIRTH");
            cbSex.Text = gridView1.GetFocusedRowCellDisplayText("CZSEX");
            txtAdress.Text = gridView1.GetFocusedRowCellDisplayText("CZADDRESS");
            txtPosition.Text = gridView1.GetFocusedRowCellDisplayText("POSITION");
            comboBox1.Text = gridView1.GetFocusedRowCellDisplayText("FRCODE");
            txtCC.Enabled = false;
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            txtCC.Text = "";
            txtCN.Text = "";
            dtBirth.Text = "";
            cbSex.Text = "";
            txtAdress.Text = "";
            txtPosition.Text = "";
            comboBox1.Text = "";
            txtCC.Focus();
            txtCC.Enabled = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (this.txtCC.Text.Length == 0)
                MessageBox.Show("Not be empty citizen code");
            else
                if (this.txtCN.Text.Length == 0)
                    MessageBox.Show("Not be empty citizen name");
                else
                    if (this.cbSex.Text.Length == 0)
                        MessageBox.Show("Not be empty citizen sex ");
                    else
                        if (this.dtBirth.Text.Length == 0)
                            MessageBox.Show("Not be empty citizen birth");
                        else
                            if (this.txtAdress.Text.Length == 0)
                                MessageBox.Show("Not be empty citizen address");                         
                                    else
                                        if (this.txtPosition.Text.Length == 0)
                                            MessageBox.Show("Not be empty position");
                                        else
                                            if (this.comboBox1.Text.Length == 0)
                                                MessageBox.Show("Not be empty family register");
                                            else
                                                try
                                                {
                                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                                    con.Open();
                                                    SqlCommand cmd = new SqlCommand("EDITCZ", con);// "ADDCZ" : Ten store procedure  trong csdl
                                                    cmd.CommandType = CommandType.StoredProcedure;
                                                    cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@CZNAME", txtCN.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@CZSEX", cbSex.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@CZBIRTH", dtBirth.EditValue));
                                                    cmd.Parameters.Add(new SqlParameter("@CZADRESS", txtAdress.Text.Trim()));                                     
                                                    cmd.Parameters.Add(new SqlParameter("@POSITION", txtPosition.Text.Trim()));
                                                    cmd.Parameters.Add(new SqlParameter("@FRCODE", comboBox1.Text.Trim()));
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
            if (this.txtCC.Text.Length == 0)
                MessageBox.Show("Not be empty citizen code");          
            else
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELCZ", con);// "ADDCZ" : Ten store procedure  trong csdl
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CZCODE", txtCC.Text.Trim()));                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete succesfully", "------REPORT------");
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

        private void staticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {           
          
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                    con.Open();
                    if(txtSearch.Text.Length!=0)
                    {
                        string sql = " SELECT * FROM CITIZEN WHERE CZNAME LIKE '%" + txtSearch.Text.Trim() + "%' OR CZCODE LIKE '%" + txtSearch.Text.Trim() + "%'OR FRCODE LIKE '%" + txtSearch.Text.Trim() + "%'OR POSITION LIKE '%" + txtSearch.Text.Trim() + "%'OR FRCODE LIKE '%" + txtSearch.Text.Trim() + "%'OR CZSEX LIKE '%" + txtSearch.Text.Trim() + "%' OR CZADDRESS LIKE '%" + txtSearch.Text.Trim() + "%'";                        
                        SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                        SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                        DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                        sda.Fill(dt1);
                        gridControl1.DataSource = dt1;
                    }
                    else
                    {
                        string sql = " SELECT * FROM CITIZEN ";
                        SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
                        SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                        DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                        sda.Fill(dt1);
                        gridControl1.DataSource = dt1;
                    }
                    //txtCC.DataBindings.Clear();
                    //txtCN.DataBindings.Clear();
                    //txtFRC.DataBindings.Clear();
                    //dtBirth.DataBindings.Clear();
                    //cbSex.DataBindings.Clear();
                    //txtNationa.DataBindings.Clear();
                    //txtNationality.DataBindings.Clear();
                    //txtPosition.DataBindings.Clear();
                    //txtAdress.DataBindings.Clear();
                    ////
                    txtCC.DataBindings.Add("Text", gridControl1.DataSource, "CZCODE");
                    txtCN.DataBindings.Add("Text", gridControl1.DataSource, "CZNAME");
                    comboBox1.DataBindings.Add("Text", gridControl1.DataSource, "FRCODE");
                    dtBirth.DataBindings.Add("Text", gridControl1.DataSource, "CZBIRTH");
                    cbSex.DataBindings.Add("Text", gridControl1.DataSource, "CZSEX");
                    txtPosition.DataBindings.Add("Text", gridControl1.DataSource, "POSITION");
                    txtAdress.DataBindings.Add("Text", gridControl1.DataSource, "CZADDRESS");
            
                }
                catch{
                        MessageBox.Show("Not found :( ", "--------REPORT--------");
                }
                 finally
                {
                      SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                    con.Close();

                 }
            }

        public void LOADCOMBOBOX()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            string sql = "select FRCODE FROM FAMILYREGISTER";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "FRCODE";
        }

        public string sex()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("STATISTIC2", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@TUKHOA", txtStatis.Text));
            SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
            com.Parameters.Add(resultParam);
            resultParam.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            string sex = com.Parameters["@Result"].Value.ToString();
            con.Close();
            return sex;
        }
        public string position()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("STATISTIC4", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@TUKHOA", txtStatis.Text));
            SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
            com.Parameters.Add(resultParam);
            resultParam.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            string position = com.Parameters["@Result"].Value.ToString();
            con.Close();
            return position;
        }
        public string numberoffamilyregister()
        {

            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("STATISTIC1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@TUKHOA", txtStatis.Text));
            SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
            com.Parameters.Add(resultParam);
            resultParam.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            string numberfamilyregister = com.Parameters["@Result"].Value.ToString();
            con.Close();
            return numberfamilyregister;
        }
        private void statisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.cbStatis.Text.Length == 0)
                MessageBox.Show("Please select the type of statistics");
            else
                if (this.cbStatis.Text == "Sex")
                    txtSex.Text = sex();
                else
                    if (this.cbStatis.Text == "Position")
                        txtP.Text = position();
                    else
                        if (this.cbStatis.Text == "Number Of Family Register")
                            txtNOFR.Text = numberoffamilyregister();

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
      
        }
    }
 }

