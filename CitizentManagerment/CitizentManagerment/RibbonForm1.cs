using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.Skins;
namespace CitizentManagerment
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
           // kiemtraquyen();
            skins();
            DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = "Whiteprint";
        }
        public void skins()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true);
        }
        public void kiemtraquyen()
        {
            if (Form_Login.luuquyen.quyen.Trim() == "DIRECTOR")
            {
                return;
            }
            else
                if (Form_Login.luuquyen.quyen.Trim() == "EMPLOYEE")
                {
                    managerPage.Visible=false;
                    directorPage.Visible=false;
                }
                else
                    if(Form_Login.luuquyen.quyen.Trim()=="MANAGER")
                    {
                        directorPage.Visible = false;
                    }
        }
        public void GetData(TextBox txtForm1,TextBox txtForm2)
        {
            this.barStaticItem2.Caption = txtForm1.Text;
            this.textBox1.Text = txtForm1.Text;
            this.textBox2.Text = txtForm2.Text;
        }
     
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucLicenseDrive ucLD = new ucLicenseDrive();
            ucLD.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucLD);
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            pcInfor.Controls.Clear();         
            ucCITIZEN ucNBC = new ucCITIZEN();
            ucNBC.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucNBC);
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pcInfor.Controls.Clear();
            ucMainPage ucM = new ucMainPage();
            ucM.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucM);
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_Login frl = new Form_Login();
            frl.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucInsurance ucI= new ucInsurance();
            ucI.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucI);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucSalary ucS = new ucSalary();
            ucS.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucS);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult del = MessageBox.Show("Are you sure want to exit ?", "REPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show();
            
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult del = MessageBox.Show("Are you sure want to log out ?", "REPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                this.Close();
                Form_Login frl = new Form_Login();
                frl.Show();
            }
            else
                this.Show();
           
        }

        private void btPP_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucPassport ucP = new ucPassport();
            ucP.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucP);
        }

        private void btFR_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucFamilyRegister ucFR = new ucFamilyRegister();
            ucFR.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucFR);
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            //pcInfor.Controls.Clear();
            //ucMNG ucMNG = new ucMNG();
            //ucMNG.Dock = System.Windows.Forms.DockStyle.Fill;
            //pcInfor.Controls.Add(ucMNG);
        }

        private void pcInfor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAR_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucArea ucArea = new ucArea();
            ucArea.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucArea);
        }

        private void applicationMenu1_LinkAdded(object sender, LinkEventArgs e)
        {
           
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucCZLD ucCZLD = new ucCZLD();
            ucCZLD.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucCZLD);
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucMNG ucmng = new ucMNG();
            ucmng.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucmng);
        }

        private void barButtonItem11_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucCZSL ucczsl = new ucCZSL();
            ucczsl.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucczsl);
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucCZPP ucczpp = new ucCZPP();
            ucczpp.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucczpp);
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucMNGLOGIN ucmnlg = new ucMNGLOGIN();
            ucmnlg.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucmnlg);
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucCZIS ucczis = new ucCZIS();
            ucczis.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucczis);
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucFAMILYINFOR ucFI = new ucFAMILYINFOR();
            ucFI.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucFI);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucEditPassWord uc = new ucEditPassWord();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(uc);
            uc.getdata(textBox1.Text.Trim(),textBox2.Text.Trim());
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucMNGLOGIN ucmnlg = new ucMNGLOGIN();
            ucmnlg.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucmnlg);
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucArea ucarea = new ucArea();
            ucarea.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucarea);
        }

        private void btDT_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucLog uclog = new ucLog();
            uclog.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(uclog);
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucMNG ucmng = new ucMNG();
            ucmng.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucmng);
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucOverView ucov = new ucOverView();
            ucov.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucov);
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcInfor.Controls.Clear();
            ucMNG ucmng = new ucMNG();
            ucmng.Dock = System.Windows.Forms.DockStyle.Fill;
            pcInfor.Controls.Add(ucmng);
        }
    }
}