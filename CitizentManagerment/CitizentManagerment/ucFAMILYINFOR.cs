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
    public partial class ucFAMILYINFOR : UserControl
    {
        public ucFAMILYINFOR()
        {
            InitializeComponent();
        }

        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            string sql = " SELECT * FROM FAMILYREGISTER AS F INNER JOIN CITIZEN AS C ON F.FRCODE = C.FRCODE ";
            SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn
            SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
            DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
            sda.Fill(dt1);
            gridControl1.DataSource = dt1;
            
        }
        public string familymember()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("STATISTIC1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@TUKHOA", txtFRC.Text));
            SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);
            com.Parameters.Add(resultParam);
            resultParam.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            string numberfamily = com.Parameters["@Result"].Value.ToString();
            con.Close();
            return numberfamily;
        }
        private void btType_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=CITIZENMANAGEMENT2017;Integrated Security=True");
                con.Open();
                if (this.cbType.Text.Length == 0)
                    MessageBox.Show("Please select the type !");
                else
                    if(cbType.Text=="Family Register Name")
                    {
                        string sql = " SELECT * FROM FAMILYREGISTER AS F INNER JOIN CITIZEN AS C ON F.FRCODE = C.FRCODE  WHERE FRNAME = '" + txtType.Text.Trim() + "'";
                        SqlCommand com = new SqlCommand(sql, con); // thực thi câu lệnh truy vấn                        
                        SqlDataAdapter sda = new SqlDataAdapter(com);// vẫn chuyển dữ liệu
                        DataTable dt1 = new DataTable();//khởi tạo 1 kho lưu trữ dữ liệu từ csdl
                        sda.Fill(dt1);
                        gridControl1.DataSource = dt1;
                      
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

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucFAMILYINFOR_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtFRC.Text.Length == 0)
                MessageBox.Show("Please enter FRCODE to caculate");
            else
                txtFamilyMember.Text = familymember();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
