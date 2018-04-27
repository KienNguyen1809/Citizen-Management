namespace CitizentManagerment
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbPassWord = new System.Windows.Forms.CheckBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MNPOSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 292);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.BorderColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Location = new System.Drawing.Point(546, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(53, 35);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "X";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CitizentManagerment.Properties.Resources.person_icon_blue_17;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(65, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 240);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("VNTimeH", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "CITIZEN MANAGEMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("VNTimeH", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN SCREEN";
            // 
            // btLogin
            // 
            this.btLogin.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btLogin.Appearance.Options.UseBackColor = true;
            this.btLogin.Appearance.Options.UseBorderColor = true;
            this.btLogin.Appearance.Options.UseFont = true;
            this.btLogin.Appearance.Options.UseForeColor = true;
            this.btLogin.AppearanceHovered.BorderColor = System.Drawing.Color.SkyBlue;
            this.btLogin.AppearanceHovered.Options.UseBorderColor = true;
            this.btLogin.AppearancePressed.BorderColor = System.Drawing.Color.SkyBlue;
            this.btLogin.AppearancePressed.Options.UseBorderColor = true;
            this.btLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btLogin.Location = new System.Drawing.Point(229, 393);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(134, 35);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Log in";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(130, 450);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(0, 24);
            this.lblIncorrect.TabIndex = 5;
            this.lblIncorrect.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(454, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CM Service v1.0 (1/6/2017)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ckbPassWord
            // 
            this.ckbPassWord.AutoSize = true;
            this.ckbPassWord.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.ckbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPassWord.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ckbPassWord.Location = new System.Drawing.Point(44, 423);
            this.ckbPassWord.Name = "ckbPassWord";
            this.ckbPassWord.Size = new System.Drawing.Size(122, 20);
            this.ckbPassWord.TabIndex = 3;
            this.ckbPassWord.Text = "Show password";
            this.ckbPassWord.UseVisualStyleBackColor = true;
            this.ckbPassWord.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau.Location = new System.Drawing.Point(280, 365);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(223, 22);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.txtTaiKhoan.Location = new System.Drawing.Point(280, 323);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(223, 22);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MNPOSITION});
            this.dataGridView1.Location = new System.Drawing.Point(656, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 12;
            // 
            // MNPOSITION
            // 
            this.MNPOSITION.DataPropertyName = "MNPOSITION";
            this.MNPOSITION.HeaderText = "MNPOSITION";
            this.MNPOSITION.Name = "MNPOSITION";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 13;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.AppearanceHovered.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton3.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton3.AppearancePressed.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton3.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.simpleButton3.Enabled = false;
            this.simpleButton3.Image = global::CitizentManagerment.Properties.Resources.lock_icon__1_;
            this.simpleButton3.Location = new System.Drawing.Point(99, 365);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(185, 22);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "PASSWORD        :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.AppearanceHovered.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton2.AppearancePressed.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton2.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton2.BackgroundImage = global::CitizentManagerment.Properties.Resources.User_blue_icon1;
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton2.Location = new System.Drawing.Point(99, 323);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(185, 22);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "USERNAME        :";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton4.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseBorderColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.AppearanceHovered.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton4.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton4.AppearancePressed.BorderColor = System.Drawing.Color.SkyBlue;
            this.simpleButton4.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton4.Location = new System.Drawing.Point(369, 393);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(134, 35);
            this.simpleButton4.TabIndex = 14;
            this.simpleButton4.Text = "Help ?";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 483);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.ckbPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btLogin;
        private System.Windows.Forms.Label lblIncorrect;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbPassWord;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNPOSITION;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}

