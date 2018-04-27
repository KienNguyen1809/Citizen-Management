namespace CitizentManagerment
{
    partial class ucArea
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbStatis = new System.Windows.Forms.ComboBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtNOF = new DevExpress.XtraEditors.TextEdit();
            this.txtPD = new DevExpress.XtraEditors.TextEdit();
            this.txtP = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LCCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LCNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LCPOPULATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLP = new DevExpress.XtraEditors.TextEdit();
            this.txtLN = new DevExpress.XtraEditors.TextEdit();
            this.txtLC = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNOF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cbCity);
            this.panelControl1.Controls.Add(this.cbStatis);
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Controls.Add(this.menuStrip1);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(818, 564);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(587, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOCATION";
            // 
            // cbCity
            // 
            this.cbCity.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Population",
            "Population Density"});
            this.cbCity.Location = new System.Drawing.Point(665, 9);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(139, 26);
            this.cbCity.TabIndex = 4;
            // 
            // cbStatis
            // 
            this.cbStatis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatis.FormattingEnabled = true;
            this.cbStatis.Items.AddRange(new object[] {
            "Population",
            "Population Density",
            "Number Of Family"});
            this.cbStatis.Location = new System.Drawing.Point(443, 9);
            this.cbStatis.Name = "cbStatis";
            this.cbStatis.Size = new System.Drawing.Size(138, 26);
            this.cbStatis.TabIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNOF);
            this.layoutControl1.Controls.Add(this.txtPD);
            this.layoutControl1.Controls.Add(this.txtP);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtLP);
            this.layoutControl1.Controls.Add(this.txtLN);
            this.layoutControl1.Controls.Add(this.txtLC);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 35);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(814, 527);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtNOF
            // 
            this.txtNOF.Location = new System.Drawing.Point(12, 471);
            this.txtNOF.Name = "txtNOF";
            this.txtNOF.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.txtNOF.Properties.Appearance.ForeColor = System.Drawing.Color.SkyBlue;
            this.txtNOF.Properties.Appearance.Options.UseFont = true;
            this.txtNOF.Properties.Appearance.Options.UseForeColor = true;
            this.txtNOF.Size = new System.Drawing.Size(790, 28);
            this.txtNOF.StyleController = this.layoutControl1;
            this.txtNOF.TabIndex = 17;
            // 
            // txtPD
            // 
            this.txtPD.Location = new System.Drawing.Point(409, 423);
            this.txtPD.Name = "txtPD";
            this.txtPD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPD.Properties.Appearance.ForeColor = System.Drawing.Color.SkyBlue;
            this.txtPD.Properties.Appearance.Options.UseFont = true;
            this.txtPD.Properties.Appearance.Options.UseForeColor = true;
            this.txtPD.Size = new System.Drawing.Size(393, 28);
            this.txtPD.StyleController = this.layoutControl1;
            this.txtPD.TabIndex = 16;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(12, 423);
            this.txtP.Name = "txtP";
            this.txtP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Properties.Appearance.ForeColor = System.Drawing.Color.SkyBlue;
            this.txtP.Properties.Appearance.Options.UseFont = true;
            this.txtP.Properties.Appearance.Options.UseForeColor = true;
            this.txtP.Size = new System.Drawing.Size(393, 28);
            this.txtP.StyleController = this.layoutControl1;
            this.txtP.TabIndex = 15;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 108);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 311);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LCCODE,
            this.LCNAME,
            this.LCPOPULATION});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // LCCODE
            // 
            this.LCCODE.Caption = "Area Code";
            this.LCCODE.FieldName = "ARCODE";
            this.LCCODE.Name = "LCCODE";
            this.LCCODE.Visible = true;
            this.LCCODE.VisibleIndex = 0;
            // 
            // LCNAME
            // 
            this.LCNAME.Caption = "Area Name";
            this.LCNAME.FieldName = "ARNAME";
            this.LCNAME.Name = "LCNAME";
            this.LCNAME.Visible = true;
            this.LCNAME.VisibleIndex = 1;
            // 
            // LCPOPULATION
            // 
            this.LCPOPULATION.Caption = "Population";
            this.LCPOPULATION.FieldName = "ARPOPULATION";
            this.LCPOPULATION.Name = "LCPOPULATION";
            this.LCPOPULATION.Visible = true;
            this.LCPOPULATION.VisibleIndex = 2;
            // 
            // txtLP
            // 
            this.txtLP.Location = new System.Drawing.Point(104, 76);
            this.txtLP.Name = "txtLP";
            this.txtLP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLP.Properties.Appearance.Options.UseFont = true;
            this.txtLP.Size = new System.Drawing.Size(698, 28);
            this.txtLP.StyleController = this.layoutControl1;
            this.txtLP.TabIndex = 6;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(104, 44);
            this.txtLN.Name = "txtLN";
            this.txtLN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLN.Properties.Appearance.Options.UseFont = true;
            this.txtLN.Size = new System.Drawing.Size(698, 28);
            this.txtLN.StyleController = this.layoutControl1;
            this.txtLN.TabIndex = 5;
            // 
            // txtLC
            // 
            this.txtLC.Location = new System.Drawing.Point(104, 12);
            this.txtLC.Name = "txtLC";
            this.txtLC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLC.Properties.Appearance.Options.UseFont = true;
            this.txtLC.Size = new System.Drawing.Size(698, 28);
            this.txtLC.StyleController = this.layoutControl1;
            this.txtLC.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(814, 527);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtLC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(794, 32);
            this.layoutControlItem1.Text = "AREA Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtLN;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(794, 32);
            this.layoutControlItem2.Text = "AREA Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtLP;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(794, 32);
            this.layoutControlItem3.Text = "Population";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(794, 315);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtP;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 411);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(397, 48);
            this.layoutControlItem6.Text = "Population";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtPD;
            this.layoutControlItem7.Location = new System.Drawing.Point(397, 411);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(397, 48);
            this.layoutControlItem7.Text = "Population Density";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtNOF;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 459);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(794, 48);
            this.layoutControlItem8.Text = "Number of family";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(89, 13);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btEdit,
            this.btClear,
            this.btPrint,
            this.statisticalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btEdit
            // 
            this.btEdit.Image = global::CitizentManagerment.Properties.Resources.Pencil_icon;
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(72, 29);
            this.btEdit.Text = "Edit";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click_1);
            // 
            // btClear
            // 
            this.btClear.Image = global::CitizentManagerment.Properties.Resources.Clear_icon;
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(84, 29);
            this.btClear.Text = "Clear";
            this.btClear.Click += new System.EventHandler(this.btClear_Click_1);
            // 
            // btPrint
            // 
            this.btPrint.Image = global::CitizentManagerment.Properties.Resources.print_icon;
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(80, 29);
            this.btPrint.Text = "Print";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click_1);
            // 
            // statisticalToolStripMenuItem
            // 
            this.statisticalToolStripMenuItem.Image = global::CitizentManagerment.Properties.Resources.SEO_icon;
            this.statisticalToolStripMenuItem.Name = "statisticalToolStripMenuItem";
            this.statisticalToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.statisticalToolStripMenuItem.Text = "Statistical";
            this.statisticalToolStripMenuItem.Click += new System.EventHandler(this.statisticalToolStripMenuItem_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(535, 9);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::CitizentManagerment.Properties.Resources.add_icon;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 29);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // ucArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucArea";
            this.Size = new System.Drawing.Size(818, 564);
            this.Load += new System.EventHandler(this.ucArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNOF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn LCCODE;
        private DevExpress.XtraGrid.Columns.GridColumn LCNAME;
        private DevExpress.XtraGrid.Columns.GridColumn LCPOPULATION;
        private DevExpress.XtraEditors.TextEdit txtLP;
        private DevExpress.XtraEditors.TextEdit txtLN;
        private DevExpress.XtraEditors.TextEdit txtLC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btEdit;
        private System.Windows.Forms.ToolStripMenuItem btClear;
        private System.Windows.Forms.ToolStripMenuItem btPrint;
        private System.Windows.Forms.ComboBox cbStatis;
        private System.Windows.Forms.ToolStripMenuItem statisticalToolStripMenuItem;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txtPD;
        private DevExpress.XtraEditors.TextEdit txtP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCity;
        private DevExpress.XtraEditors.TextEdit txtNOF;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
    }
}
