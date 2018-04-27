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
    public partial class ucArea : UserControl
    {
        public ucArea()
        {
            InitializeComponent();
        }

        private void ucArea_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
      //      loadComboBox();
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "select * from AREA";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (this.txtLC.Text.Length == 0)
                MessageBox.Show("Not be empty location code");
            else
                if (this.txtLN.Text.Length == 0)
                    MessageBox.Show("Not be empty location name");
                else
                    if (this.txtLP.Text.Length == 0)
                        MessageBox.Show("Not be empty location population");                 
                            else
                                try
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("EDITLC", con);// "ADDCZ" : Ten store procedure  trong csdl
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add(new SqlParameter("@LCCODE", txtLC.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@LCNAME", txtLN.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@LCPOPULATION", txtLP.Text.Trim()));
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Edit successfully", "------REPORT------");
                                    cmd.Dispose();
                                    ketnoicsdl();
                                }
                                catch
                                {
                                    MessageBox.Show("Can not be Editted !", "---------ERROR--------");
                                }
                                finally
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                    con.Close();
                                }

        }


        private void btClear_Click(object sender, EventArgs e)
        {
            txtLC.Text = "";
            txtLN.Text = "";
            txtLP.Text = "";        
            txtLC.Focus();
            txtLC.Enabled = true;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

     
        private void btClear_Click_1(object sender, EventArgs e)
        {
            txtLC.Text = "";
            txtLN.Text = "";
            txtLP.Text = "";
            txtLC.Focus();
            txtLC.Enabled = true;
        }

        private void btPrint_Click_1(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            txtLC.Text = gridView1.GetFocusedRowCellDisplayText("ARCODE");
            txtLN.Text = gridView1.GetFocusedRowCellDisplayText("ARNAME");           
            txtLP.Text = gridView1.GetFocusedRowCellDisplayText("ARPOPULATION");
            txtLC.Enabled = false;
        }

        private void btEdit_Click_1(object sender, EventArgs e)
        {
            if (this.txtLC.Text.Length == 0)
                MessageBox.Show("Not be empty location code");
            else
                if (this.txtLN.Text.Length == 0)
                    MessageBox.Show("Not be empty location name");
                else
                    if (this.txtLP.Text.Length == 0)
                        MessageBox.Show("Not be empty location population");
                            else

                                try
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand("EDITAREA", con);// "ADDCZ" : Ten store procedure  trong csdl
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.Add(new SqlParameter("@ARCODE", txtLC.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@ARNAME", txtLN.Text.Trim()));
                                    cmd.Parameters.Add(new SqlParameter("@ARPOPULATION", txtLP.Text.Trim()));
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Edit successfully", "------REPORT------");
                                    cmd.Dispose();
                                    ketnoicsdl();
                                }
                                catch
                                {
                                    MessageBox.Show("Can not be Editted !", "---------ERROR--------");
                                }
                                finally
                                {
                                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                                    con.Close();
                                }
        }


        private void statisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.cbStatis.Text.Length == 0)
            //    MessageBox.Show(" Please select the type of statistics");
            //else
            //    if (cbStatis.Text == "Population")
            //        txtP.Text = tongsonguoi();
            //    else
            //        if (cbStatis.Text == "Population Density")
            //            txtPD.Text = matdodanso();
            //        else
            //            if (cbStatis.Text == "Number Of Family")
            //                txtNOF.Text = memberoffamily();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtLC.Text.Length == 0)
                MessageBox.Show("Not be empty location code");
            else
                if (this.txtLN.Text.Length == 0)
                    MessageBox.Show("Not be empty location name");
                else
                    if (this.txtLP.Text.Length == 0)
                        MessageBox.Show("Not be empty location population");
                    else
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("ADDAREA", con);// "ADDCZ" : Ten store procedure  trong csdl
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@ARCODE", txtLC.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@ARNAME", txtLN.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@ARPOPULATION", txtLP.Text.Trim()));
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
    
    //    public string memberoffamily()
    //    {
    ////        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPNHATLINH\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT_4;Integrated Security=True");
    ////        con.Open();
    ////        SqlCommand com = new SqlCommand("COUNTFR", con);
    ////        com.CommandType = CommandType.StoredProcedure;
    ////        com.Parameters.Add(new SqlParameter("@LCCODE", cbCity.Text));
    ////        SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
    ////        com.Parameters.Add(resultParam);
    ////        resultParam.Direction = ParameterDirection.ReturnValue;
    ////        com.ExecuteNonQuery();
    ////        string memberoffamily = com.Parameters["@Result"].Value.ToString();
    ////        con.Close();
    ////        return memberoffamily;
    //    }
       //public string tongsonguoi()
    //    {
    ////        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPNHATLINH\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT_4;Integrated Security=True");
    ////        con.Open();
    ////        SqlCommand com = new SqlCommand("STATISTIC3", con);
    ////        com.CommandType = CommandType.StoredProcedure;
    ////        com.Parameters.Add(new SqlParameter("@TUKHOA", cbCity.Text));                      
    ////        SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
    ////        com.Parameters.Add(resultParam);
    ////        resultParam.Direction = ParameterDirection.ReturnValue;            
    ////        com.ExecuteNonQuery();
    ////        string songuoi = com.Parameters["@Result"].Value.ToString();
    ////        con.Close();
    ////        return songuoi;
    //    }

    //    public string matdodanso()
    //   {
    ////       SqlConnection con = new SqlConnection(@"Data Source=LAPTOPNHATLINH\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT_4;Integrated Security=True");
    ////       con.Open();
    ////       SqlCommand com = new SqlCommand("MDDS", con);
    ////       com.CommandType = CommandType.StoredProcedure;
    ////       com.Parameters.Add(new SqlParameter("@TUKHOA", cbCity.Text));
    ////       SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
    ////       com.Parameters.Add(resultParam);
    ////       resultParam.Direction = ParameterDirection.ReturnValue;
    ////       com.ExecuteNonQuery();
    ////       string matdodanso = com.Parameters["@Result"].Value.ToString();
    ////       con.Close();
    ////       return matdodanso;
    //  }
        
    //    public void loadComboBox()
    //   {
    ////        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPNHATLINH\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT_4;Integrated Security=True");
    ////        string sql = "select LCNAME from LOCATION";
    ////        SqlCommand com = new SqlCommand(sql, con);
    ////        SqlDataAdapter da = new SqlDataAdapter(com);
    ////        DataTable dt = new DataTable();
    ////        da.Fill(dt);
    ////        cbCity.DataSource = dt;
    ////        cbCity.DisplayMember = "LCNAME";
    //   }
    }
}
