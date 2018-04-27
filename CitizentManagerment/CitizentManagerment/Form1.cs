using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CitizentManagerment
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        public class luuquyen
        {
            public static string quyen;
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbPassWord.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
          //  SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOPNHATLINH\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT_2017;Integrated Security=True");
          // // SqlDataAdapter sda = new SqlDataAdapter("select count(*) ADMINLG TK where ADMINCODE='" + txtTaiKhoan.Text + "'and PASSWORDAD='" + txtMatKhau.Text + "'", sqlcon);         
          //  SqlCommand cmd = new SqlCommand("select count(*) ADMINLG TK where ADMINCODE='" + txtTaiKhoan.Text + "'and PASSWORDAD='" + txtMatKhau.Text + "'", sqlcon);
          //  DataTable dt = new DataTable();
          ////  sda.Fill(dt);
          //  SqlDataAdapter data = new SqlDataAdapter(cmd);
          ////  DataTable dt1 = new DataTable();
          //  data.Fill(dt);
          //  dataGridView1.DataSource = dt;
          //  if (dt.Rows[0][0].ToString() == "1" || dt.Rows[0][0].ToString() == "2")
          //  {
          //      //int index;
          //      //index = dataGridView1.CurrentRow.Index;
          //      //textBox1.Text = dataGridView1.Rows[index].Cells[index].Value.ToString();
          //      //luuquyen.quyen = textBox1.Text;
          //      //RibbonForm1 rb = new RibbonForm1();
          //      //rb.Show();
          //      //this.Hide();               
          //      //PassingData pd = new PassingData(rb.GetData);
          //      //pd(this.txtTaiKhoan,this.txtMatKhau);
          //  }
          //  else
          //  {
          //      lblIncorrect.Text = "Account or password is incorrect";
          //      txtTaiKhoan.Text = "";
          //      txtMatKhau.Text = "";
          //      txtTaiKhoan.Focus();
          //  }      

            SqlConnection sqlcon = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");      
            sqlcon.Open();
            string sql = "select count(*) from ADMINLG where ADMINCODE='"+txtTaiKhoan.Text+"' AND PASSWORDAD='"+txtMatKhau.Text+"'";
            SqlCommand command = new SqlCommand(sql, sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (this.txtTaiKhoan.TextLength == 0 || this.txtMatKhau.TextLength == 0)
            {
                lblIncorrect.Text = "You have not entered your UserName or Password ";
            }
            else
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    RibbonForm1 rb = new RibbonForm1();
                    rb.Show();
                    this.Hide();
                }
                else
                {
                    lblIncorrect.Text = "UserName or Password is incorrect";
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
            }
        }

        public delegate void PassingData(TextBox text,TextBox text2);

        //public void loadLabel()
        //{
        //    RibbonForm1 rb= new RibbonForm1();
        //    PassingData pd = new PassingData(rb.GetData);
        //    pd(this.txtTaiKhoan);
        //}
        private void Form_Login_Load(object sender, EventArgs e)
        {
            //loadLabel();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
