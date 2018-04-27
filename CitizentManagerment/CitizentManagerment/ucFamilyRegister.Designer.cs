namespace CitizentManagerment
{
    partial class ucFamilyRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFamilyRegister));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FRCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FRNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NUMMEMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtN = new DevExpress.XtraEditors.TextEdit();
            this.txtFRN = new DevExpress.XtraEditors.TextEdit();
            this.txtFRC = new DevExpress.XtraEditors.TextEdit();
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
            this.txtClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAC = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFRN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFRC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Controls.Add(this.menuStrip1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(818, 529);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtSearch);
            this.layoutControl1.Controls.Add(this.btSearch);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtN);
            this.layoutControl1.Controls.Add(this.txtFRN);
            this.layoutControl1.Controls.Add(this.txtFRC);
            this.layoutControl1.Controls.Add(this.txtAC);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 35);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(814, 500);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(118, 134);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(593, 26);
            this.txtSearch.StyleController = this.layoutControl1;
            this.txtSearch.TabIndex = 10;
            // 
            // btSearch
            // 
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.Location = new System.Drawing.Point(715, 134);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(87, 38);
            this.btSearch.StyleController = this.layoutControl1;
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 176);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 312);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FRCODE,
            this.FRNAME,
            this.NUMMEMBER,
            this.ARCODE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FRCODE
            // 
            this.FRCODE.Caption = "FAMILY REGISTER CODE";
            this.FRCODE.FieldName = "FRCODE";
            this.FRCODE.Name = "FRCODE";
            this.FRCODE.Visible = true;
            this.FRCODE.VisibleIndex = 0;
            // 
            // FRNAME
            // 
            this.FRNAME.Caption = "FAMILY REGISTER NAME";
            this.FRNAME.FieldName = "FRNAME";
            this.FRNAME.Name = "FRNAME";
            this.FRNAME.Visible = true;
            this.FRNAME.VisibleIndex = 1;
            // 
            // NUMMEMBER
            // 
            this.NUMMEMBER.Caption = "NUMMEMBER1 ";
            this.NUMMEMBER.FieldName = "NUMMEMBER";
            this.NUMMEMBER.Name = "NUMMEMBER";
            this.NUMMEMBER.Visible = true;
            this.NUMMEMBER.VisibleIndex = 2;
            // 
            // ARCODE
            // 
            this.ARCODE.Caption = "AREA CODE";
            this.ARCODE.FieldName = "ARCODE";
            this.ARCODE.Name = "ARCODE";
            this.ARCODE.Visible = true;
            this.ARCODE.VisibleIndex = 3;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(118, 72);
            this.txtN.Name = "txtN";
            this.txtN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Properties.Appearance.Options.UseFont = true;
            this.txtN.Size = new System.Drawing.Size(684, 26);
            this.txtN.StyleController = this.layoutControl1;
            this.txtN.TabIndex = 6;
            // 
            // txtFRN
            // 
            this.txtFRN.Location = new System.Drawing.Point(118, 42);
            this.txtFRN.Name = "txtFRN";
            this.txtFRN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFRN.Properties.Appearance.Options.UseFont = true;
            this.txtFRN.Size = new System.Drawing.Size(684, 26);
            this.txtFRN.StyleController = this.layoutControl1;
            this.txtFRN.TabIndex = 5;
            // 
            // txtFRC
            // 
            this.txtFRC.Location = new System.Drawing.Point(118, 12);
            this.txtFRC.Name = "txtFRC";
            this.txtFRC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFRC.Properties.Appearance.Options.UseFont = true;
            this.txtFRC.Size = new System.Drawing.Size(684, 26);
            this.txtFRC.StyleController = this.layoutControl1;
            this.txtFRC.TabIndex = 4;
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
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(814, 500);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtFRC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(794, 30);
            this.layoutControlItem1.Text = "Family Register Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtFRN;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(794, 30);
            this.layoutControlItem2.Text = "Family Register Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtN;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(794, 30);
            this.layoutControlItem3.Text = "Numenber";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 164);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(794, 316);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btSearch;
            this.layoutControlItem5.Location = new System.Drawing.Point(703, 122);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(91, 42);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtSearch;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(703, 42);
            this.layoutControlItem7.Text = "Search";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtAC;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(794, 32);
            this.layoutControlItem8.Text = "Area Code";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(103, 13);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btEdit,
            this.txtClear,
            this.btPrint});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 33);
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
            // txtClear
            // 
            this.txtClear.Image = global::CitizentManagerment.Properties.Resources.Clear_icon;
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(84, 29);
            this.txtClear.Text = "Clear";
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // btPrint
            // 
            this.btPrint.Image = global::CitizentManagerment.Properties.Resources.print_icon;
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(80, 29);
            this.btPrint.Text = "Print";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(118, 102);
            this.txtAC.Name = "txtAC";
            this.txtAC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.txtAC.Properties.Appearance.Options.UseFont = true;
            this.txtAC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtAC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtAC.Size = new System.Drawing.Size(684, 28);
            this.txtAC.StyleController = this.layoutControl1;
            this.txtAC.TabIndex = 11;
            // 
            // ucFamilyRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucFamilyRegister";
            this.Size = new System.Drawing.Size(818, 529);
            this.Load += new System.EventHandler(this.ucFamilyRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFRN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFRC.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtAC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtN;
        private DevExpress.XtraEditors.TextEdit txtFRN;
        private DevExpress.XtraEditors.TextEdit txtFRC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.ToolStripMenuItem btAdd;
        private System.Windows.Forms.ToolStripMenuItem btEdit;
        private System.Windows.Forms.ToolStripMenuItem btPrint;
        private System.Windows.Forms.ToolStripMenuItem txtClear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn FRCODE;
        private DevExpress.XtraGrid.Columns.GridColumn FRNAME;
        private DevExpress.XtraGrid.Columns.GridColumn NUMMEMBER;
        private DevExpress.XtraGrid.Columns.GridColumn ARCODE;
        private DevExpress.XtraEditors.TextEdit txtAC;
    }
}
