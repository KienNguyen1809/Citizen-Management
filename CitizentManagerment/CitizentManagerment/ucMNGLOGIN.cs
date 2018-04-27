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
    public partial class ucMNGLOGIN : UserControl
    {
        public ucMNGLOGIN()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();  

            string sql = "select MNCODE,MNPASSWORD,MNPOSITION from MANAGER ";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            string sql2 = "select * from ADMINLG ";
            SqlCommand com2 = new SqlCommand(sql2, con);
            SqlDataAdapter da2 = new SqlDataAdapter(com);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            gridControl2.DataSource = dt2;


        }
        private void ucMNGLOGIN_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

     
    }
}
