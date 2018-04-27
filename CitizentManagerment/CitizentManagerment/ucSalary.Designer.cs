namespace CitizentManagerment
{
    partial class ucSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSalary));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.sbSearch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMoney = new DevExpress.XtraEditors.TextEdit();
            this.txtSN = new DevExpress.XtraEditors.TextEdit();
            this.txtSC = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.SLCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLMONEY = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl2.Controls.Add(this.layoutControl1);
            this.panelControl2.Controls.Add(this.menuStrip1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(784, 496);
            this.panelControl2.TabIndex = 1;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btSearch);
            this.layoutControl1.Controls.Add(this.txtSearch);
            this.layoutControl1.Controls.Add(this.sbSearch);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtMoney);
            this.layoutControl1.Controls.Add(this.txtSN);
            this.layoutControl1.Controls.Add(this.txtSC);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 35);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(780, 465);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btSearch
            // 
            this.btSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Appearance.Options.UseFont = true;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.Location = new System.Drawing.Point(652, 102);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(116, 38);
            this.btSearch.StyleController = this.layoutControl1;
            this.btSearch.TabIndex = 10;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(200, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(448, 26);
            this.txtSearch.StyleController = this.layoutControl1;
            this.txtSearch.TabIndex = 9;
            // 
            // sbSearch
            // 
            this.sbSearch.Location = new System.Drawing.Point(75, 102);
            this.sbSearch.Name = "sbSearch";
            this.sbSearch.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSearch.Properties.Appearance.Options.UseFont = true;
            this.sbSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sbSearch.Size = new System.Drawing.Size(121, 26);
            this.sbSearch.StyleController = this.layoutControl1;
            this.sbSearch.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(756, 309);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SLCODE,
            this.SLNAME,
            this.SLMONEY});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(75, 72);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Properties.Appearance.Options.UseFont = true;
            this.txtMoney.Size = new System.Drawing.Size(693, 26);
            this.txtMoney.StyleController = this.layoutControl1;
            this.txtMoney.TabIndex = 6;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(75, 42);
            this.txtSN.Name = "txtSN";
            this.txtSN.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Properties.Appearance.Options.UseFont = true;
            this.txtSN.Size = new System.Drawing.Size(693, 26);
            this.txtSN.StyleController = this.layoutControl1;
            this.txtSN.TabIndex = 5;
            // 
            // txtSC
            // 
            this.txtSC.Location = new System.Drawing.Point(75, 12);
            this.txtSC.Name = "txtSC";
            this.txtSC.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSC.Properties.Appearance.Options.UseFont = true;
            this.txtSC.Size = new System.Drawing.Size(693, 26);
            this.txtSC.StyleController = this.layoutControl1;
            this.txtSC.TabIndex = 4;
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
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 465);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSC;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(760, 30);
            this.layoutControlItem1.Text = "Salary Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSN;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(760, 30);
            this.layoutControlItem2.Text = "Salary Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtMoney;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(760, 30);
            this.layoutControlItem3.Text = "Money";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(760, 313);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbSearch;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(188, 42);
            this.layoutControlItem5.Text = "Search by";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtSearch;
            this.layoutControlItem6.Location = new System.Drawing.Point(188, 90);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(452, 42);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btSearch;
            this.layoutControlItem7.Location = new System.Drawing.Point(640, 90);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(120, 42);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
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
            this.btPrint});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 33);
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
            // SLCODE
            // 
            this.SLCODE.Caption = "SALARY CODE";
            this.SLCODE.FieldName = "SLCODE";
            this.SLCODE.Name = "SLCODE";
            this.SLCODE.Visible = true;
            this.SLCODE.VisibleIndex = 0;
            // 
            // SLNAME
            // 
            this.SLNAME.Caption = "SALARY NAME";
            this.SLNAME.FieldName = "SLNAME";
            this.SLNAME.Name = "SLNAME";
            this.SLNAME.Visible = true;
            this.SLNAME.VisibleIndex = 1;
            // 
            // SLMONEY
            // 
            this.SLMONEY.Caption = "SALARY MONEY ";
            this.SLMONEY.FieldName = "SLMONEY";
            this.SLMONEY.Name = "SLMONEY";
            this.SLMONEY.Visible = true;
            this.SLMONEY.VisibleIndex = 2;
            // 
            // ucSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Name = "ucSalary";
            this.Size = new System.Drawing.Size(784, 496);
            this.Load += new System.EventHandler(this.ucSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtMoney;
        private DevExpress.XtraEditors.TextEdit txtSN;
        private DevExpress.XtraEditors.TextEdit txtSC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btAdd;
        private System.Windows.Forms.ToolStripMenuItem btEdit;
        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private System.Windows.Forms.ToolStripMenuItem btClear;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.ComboBoxEdit sbSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.ToolStripMenuItem btPrint;
        private DevExpress.XtraGrid.Columns.GridColumn SLCODE;
        private DevExpress.XtraGrid.Columns.GridColumn SLNAME;
        private DevExpress.XtraGrid.Columns.GridColumn SLMONEY;
    }
}
