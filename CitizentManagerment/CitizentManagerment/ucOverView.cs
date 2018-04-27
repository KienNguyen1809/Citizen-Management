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
    public partial class ucOverView : UserControl
    {
        public ucOverView()
        {
            InitializeComponent();
        }

        private void ucOverView_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = "SELECT * FROM OVERVIEW";
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
                string sql = "SELECT * FROM OVERVIEW WHERE CZNAME LIKE '%" + txtSearch.Text.Trim() + "%'  OR CZBIRTH = '%" + txtSearch.Text + "%' OR CZADDRESS LIKE '%" + txtSearch.Text + "%' OR NATION LIKE '%" + txtSearch.Text + "%' OR NATIONALITY LIKE '%" + txtSearch.Text + "%' OR POSITION LIKE '%" + txtSearch.Text + "%' OR ISCODE LIKE '%" + txtSearch.Text + "%' OR LDCODE LIKE '%" + txtSearch.Text + "%' OR PPCODE LIKE '%" + txtSearch.Text + "%' OR SLCODE LIKE '%" + txtSearch.Text + "%' OR FRCODE LIKE '%" + txtSearch.Text + "%'  ";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("NOT FOUND !","----------REPORT----------");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Close();
            }
        }

    }
}
