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
    public partial class ucPassport : UserControl
    {
        public ucPassport()
        {
            InitializeComponent();
        }

        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "SELECT * FROM PASSPORT";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ađToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtPPC.Text.Length == 0)
                MessageBox.Show("Not be empty passport code");
            else
                if (this.txtPN.Text.Length == 0)
                    MessageBox.Show("Not be empty passport name");
                else
                if (this.txtTerminable.Text.Length == 0)
                    MessageBox.Show("Not be empty terminable");
                else  
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("ADDPP", con);// "ADDCZ" : Ten store procedure  trong csdl
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@PPCODE", txtPPC.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PPNAME", txtPN.Text.Trim()));
                            cmd.Parameters.Add(new SqlParameter("@PPTM", txtTerminable.Text.Trim()));
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

        private void ucPassport_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtPPC.Text.Length == 0)
                MessageBox.Show("Not be empty passport code");
            else
                if (this.txtTerminable.Text.Length == 0)
                    MessageBox.Show("Not be empty terminable");
                else
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("EDITPP", con);// "ADDCZ" : Ten store procedure  trong csdl
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@PPCODE", txtPPC.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@PPNAME", txtPN.Text.Trim()));
                        cmd.Parameters.Add(new SqlParameter("@PPTM", txtTerminable.Text.Trim()));
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtPPC.Text.Length == 0)
                MessageBox.Show("Not be empty passport code");
            else               
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELPP", con);// "ADDCZ" : Ten store procedure  trong csdl
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@PPCODE", txtPPC.Text.Trim()));                        
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
    }
}
