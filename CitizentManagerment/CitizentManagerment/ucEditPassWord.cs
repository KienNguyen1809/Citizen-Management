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
    public partial class ucEditPassWord : UserControl
    {
        public ucEditPassWord()
        {
            InitializeComponent();
        }

      
        public void getdata(string data,string data2)
        {
            lblCurrentPassword.Text = data2;
            lblUserName.Text = data;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucEditPassWord_Load(object sender, EventArgs e)
        {
            //ketnoicsdl();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if ((txtCurrentPassword.Text == "") || (txtNewPassword.Text == "") || (txtRetype.Text ==""))
            {
                MessageBox.Show("One or more Fields are Empty...!");

            }
            else if(txtNewPassword.Text != txtRetype.Text)
            {
                MessageBox.Show("Password mismatch... !");
            }
            else if(txtCurrentPassword.Text !=lblCurrentPassword.Text)
            {
                MessageBox.Show("Wrong current password...!");
            }

            else
            {
                DialogResult del = MessageBox.Show("Are you sure want to change your password ?","REPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                    con.Open();

                    SqlCommand com = new SqlCommand("UPDATE MNLOGIN SET MNPASS='" + txtNewPassword.Text + "' where MNCODE ='" + lblUserName.Text + "'",con);
                    com.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY");
                    txtCurrentPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtRetype.Text = "";

                    con.Close();
                    this.Refresh();
                }
                else
                    this.Show();
            }       
        }      
        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkButton1.Checked)
                txtCurrentPassword.UseSystemPasswordChar = false;
            else
                txtCurrentPassword.UseSystemPasswordChar = true;

        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton2.Checked)
                txtNewPassword.UseSystemPasswordChar = false;
            else
                txtNewPassword.UseSystemPasswordChar = true;
        }

        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton3.Checked)
                txtRetype.UseSystemPasswordChar = false;
            else
                txtRetype.UseSystemPasswordChar = true;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if ((txtCurrentPassword.Text == "") || (txtNewPassword.Text == "") || (txtRetype.Text == ""))
            {
                MessageBox.Show("One or more fields are EMPTY...!");

            }
            else if (txtNewPassword.Text != txtRetype.Text)
            {
                MessageBox.Show("Password mismatch... !");
            }
            else if (txtCurrentPassword.Text != lblCurrentPassword.Text)
            {
                MessageBox.Show("Wrong current password...!");
            }

            else
            {
                DialogResult del = MessageBox.Show("Are you sure want to change your password ?", "REPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                    con.Open();

                    SqlCommand com = new SqlCommand("UPDATE MNLOGIN SET MNPASS='" + txtNewPassword.Text + "' where MNCODE ='" + lblUserName.Text + "'", con);
                    com.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY");
                    txtCurrentPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtRetype.Text = "";

                    //con.Close();
                    //this.Refresh();
                }
                else
                    this.Show();
            }       
        }
    }
}
