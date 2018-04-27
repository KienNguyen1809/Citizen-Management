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
    public partial class ucLog : UserControl
    {
        public ucLog()
        {
            InitializeComponent();
        }

      
        private void btDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                
                if(cbTable.Text=="CITIZEN")
                {
                   gridView1.Columns.Clear();
                   SqlCommand cmd = new SqlCommand("SELECT * FROM CZLOG", con);                  
                   cmd.ExecuteNonQuery();                  
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   DataTable dt = new DataTable();
                   da.Fill(dt);  
                   gridControl1.DataSource= dt;
                }
                else if (cbTable.Text == "LICENSE DRIVE")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LGLD", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                
               else if(cbTable.Text=="FAMILY REGISTER")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM FRLOG", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                else if (cbTable.Text == "INSURANCE")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ISLOG", con);                   
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                else if (cbTable.Text == "SALARY")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LOGSL", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                else if (cbTable.Text == "PASSPORT")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LOGPP", con);                   
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                else if (cbTable.Text == "LOCATION")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LCLOG", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                else if (cbTable.Text == "CITIZEN LICENSE DRIVE")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LGCZLD", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                else if (cbTable.Text == "CITIZEN INSURANCE")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LGCZIS", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                else if (cbTable.Text == "CITIZEN SALARY")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LGCZSL", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                else if (cbTable.Text == "CITIZEN PASSPORT")
                {
                    gridView1.Columns.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LGCZPP", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
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

        private void btPrint_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
