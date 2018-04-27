namespace CitizentManagerment
{
    partial class ucCZPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCZPP));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CZCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPSTARTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PPENDTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCC = new DevExpress.XtraEditors.TextEdit();
            this.txtPC = new DevExpress.XtraEditors.TextEdit();
            this.dtPST = new DevExpress.XtraEditors.DateEdit();
            this.dtPET = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btStatistical = new System.Windows.Forms.ToolStripMenuItem();
            this.txtStatistical = new DevExpress.XtraEditors.TextEdit();
            this.txtStatis = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPST.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPET.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatistical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtStatistical);
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Controls.Add(this.menuStrip1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(850, 542);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtStatis);
            this.layoutControl1.Controls.Add(this.btSearch);
            this.layoutControl1.Controls.Add(this.txtSearch);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtCC);
            this.layoutControl1.Controls.Add(this.txtPC);
            this.layoutControl1.Controls.Add(this.dtPST);
            this.layoutControl1.Controls.Add(this.dtPET);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 35);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(846, 505);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btSearch
            // 
            this.btSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.btSearch.Appearance.Options.UseFont = true;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.Location = new System.Drawing.Point(692, 140);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(142, 38);
            this.btSearch.StyleController = this.layoutControl1;
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(110, 140);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(578, 28);
            this.txtSearch.StyleController = this.layoutControl1;
            this.txtSearch.TabIndex = 10;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 182);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(822, 287);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CZCODE,
            this.PPCODE,
            this.PPSTARTIME,
            this.PPENDTIME});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // CZCODE
            // 
            this.CZCODE.Caption = "CITIZEN CODE";
            this.CZCODE.FieldName = "CZCODE";
            this.CZCODE.Name = "CZCODE";
            this.CZCODE.Visible = true;
            this.CZCODE.VisibleIndex = 0;
            // 
            // PPCODE
            // 
            this.PPCODE.Caption = "PASSPORT CODE";
            this.PPCODE.FieldName = "PPCODE";
            this.PPCODE.Name = "PPCODE";
            this.PPCODE.Visible = true;
            this.PPCODE.VisibleIndex = 1;
            // 
            // PPSTARTIME
            // 
            this.PPSTARTIME.Caption = "PASSPORT STAT TIME";
            this.PPSTARTIME.FieldName = "PPSTARTIME";
            this.PPSTARTIME.Name = "PPSTARTIME";
            this.PPSTARTIME.Visible = true;
            this.PPSTARTIME.VisibleIndex = 2;
            // 
            // PPENDTIME
            // 
            this.PPENDTIME.Caption = "PASSPORT END TIME";
            this.PPENDTIME.FieldName = "PPENDTIME";
            this.PPENDTIME.Name = "PPENDTIME";
            this.PPENDTIME.Visible = true;
            this.PPENDTIME.VisibleIndex = 3;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(110, 44);
            this.txtCC.Name = "txtCC";
            this.txtCC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.Properties.Appearance.Options.UseFont = true;
            this.txtCC.Size = new System.Drawing.Size(724, 28);
            this.txtCC.StyleController = this.layoutControl1;
            this.txtCC.TabIndex = 5;
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(110, 12);
            this.txtPC.Name = "txtPC";
            this.txtPC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPC.Properties.Appearance.Options.UseFont = true;
            this.txtPC.Size = new System.Drawing.Size(724, 28);
            this.txtPC.StyleController = this.layoutControl1;
            this.txtPC.TabIndex = 4;
            // 
            // dtPST
            // 
            this.dtPST.EditValue = null;
            this.dtPST.Location = new System.Drawing.Point(110, 76);
            this.dtPST.Name = "dtPST";
            this.dtPST.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPST.Properties.Appearance.Options.UseFont = true;
            this.dtPST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPST.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPST.Properties.DisplayFormat.FormatString = "";
            this.dtPST.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtPST.Properties.EditFormat.FormatString = "";
            this.dtPST.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtPST.Properties.Mask.EditMask = "";
            this.dtPST.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtPST.Size = new System.Drawing.Size(724, 28);
            this.dtPST.StyleController = this.layoutControl1;
            this.dtPST.TabIndex = 6;
            // 
            // dtPET
            // 
            this.dtPET.EditValue = null;
            this.dtPET.Location = new System.Drawing.Point(110, 108);
            this.dtPET.Name = "dtPET";
            this.dtPET.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPET.Properties.Appearance.Options.UseFont = true;
            this.dtPET.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPET.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPET.Properties.DisplayFormat.FormatString = "";
            this.dtPET.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtPET.Properties.EditFormat.FormatString = "";
            this.dtPET.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtPET.Properties.Mask.EditMask = "";
            this.dtPET.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtPET.Size = new System.Drawing.Size(724, 28);
            this.dtPET.StyleController = this.layoutControl1;
            this.dtPET.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(846, 505);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(826, 32);
            this.layoutControlItem1.Text = "Passport Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCC;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(826, 32);
            this.layoutControlItem2.Text = "Citizen Code";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtPST;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(826, 32);
            this.layoutControlItem3.Text = "Passport Start Time";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtPET;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(826, 32);
            this.layoutControlItem4.Text = "Passport End Time";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 170);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(826, 291);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtSearch;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(680, 42);
            this.layoutControlItem7.Text = "Search";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btSearch;
            this.layoutControlItem8.Location = new System.Drawing.Point(680, 128);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(146, 42);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btEdit,
            this.btDelete,
            this.btClear,
            this.btPrint,
            this.btStatistical});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Image = global::CitizentManagerment.Properties.Resources.add_icon;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(74, 29);
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Image = global::CitizentManagerment.Properties.Resources.Pencil_icon;
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(72, 29);
            this.btEdit.Text = "Edit";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = global::CitizentManagerment.Properties.Resources.Actions_edit_delete_icon;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClear
            // 
            this.btClear.Image = global::CitizentManagerment.Properties.Resources.Clear_icon;
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(84, 29);
            this.btClear.Text = "Clear";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btPrint
            // 
            this.btPrint.Image = global::CitizentManagerment.Properties.Resources.print_icon;
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(80, 29);
            this.btPrint.Text = "Print";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btStatistical
            // 
            this.btStatistical.Image = global::CitizentManagerment.Properties.Resources.SEO_icon;
            this.btStatistical.Name = "btStatistical";
            this.btStatistical.Size = new System.Drawing.Size(119, 29);
            this.btStatistical.Text = "Statistical";
            this.btStatistical.Click += new System.EventHandler(this.btStatistical_Click);
            // 
            // txtStatistical
            // 
            this.txtStatistical.Location = new System.Drawing.Point(549, 7);
            this.txtStatistical.Name = "txtStatistical";
            this.txtStatistical.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtStatistical.Properties.Appearance.Options.UseFont = true;
            this.txtStatistical.Size = new System.Drawing.Size(130, 28);
            this.txtStatistical.TabIndex = 2;
            // 
            // txtStatis
            // 
            this.txtStatis.Location = new System.Drawing.Point(110, 473);
            this.txtStatis.Name = "txtStatis";
            this.txtStatis.Size = new System.Drawing.Size(724, 20);
            this.txtStatis.StyleController = this.layoutControl1;
            this.txtStatis.TabIndex = 12;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtStatis;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 461);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(826, 24);
            this.layoutControlItem6.Text = "Number of passport";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(95, 13);
            // 
            // ucCZPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucCZPP";
            this.Size = new System.Drawing.Size(850, 542);
            this.Load += new System.EventHandler(this.ucCZPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPST.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPET.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatistical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtCC;
        private DevExpress.XtraEditors.TextEdit txtPC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.ToolStripMenuItem btAdd;
        private System.Windows.Forms.ToolStripMenuItem btEdit;
        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private System.Windows.Forms.ToolStripMenuItem btClear;
        private System.Windows.Forms.ToolStripMenuItem btPrint;
        private DevExpress.XtraGrid.Columns.GridColumn CZCODE;
        private DevExpress.XtraGrid.Columns.GridColumn PPCODE;
        private DevExpress.XtraGrid.Columns.GridColumn PPSTARTIME;
        private DevExpress.XtraGrid.Columns.GridColumn PPENDTIME;
        private DevExpress.XtraEditors.DateEdit dtPST;
        private DevExpress.XtraEditors.DateEdit dtPET;
        private DevExpress.XtraEditors.TextEdit txtStatistical;
        private DevExpress.XtraEditors.TextEdit txtStatis;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.ToolStripMenuItem btStatistical;
    }
}
