namespace CitizentManagerment
{
    partial class ucLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLog));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btDisplay = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbTable = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btPrint);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btDisplay);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.cbTable);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1341, 534);
            this.panelControl1.TabIndex = 0;
            // 
            // btPrint
            // 
            this.btPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Appearance.Options.UseFont = true;
            this.btPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btPrint.Image = ((System.Drawing.Image)(resources.GetObject("btPrint.Image")));
            this.btPrint.Location = new System.Drawing.Point(115, 234);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(108, 37);
            this.btPrint.TabIndex = 5;
            this.btPrint.Text = "PRINT";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(26, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(181, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "DIARY TRANSACTION";
            // 
            // btDisplay
            // 
            this.btDisplay.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplay.Appearance.Options.UseFont = true;
            this.btDisplay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btDisplay.Image = ((System.Drawing.Image)(resources.GetObject("btDisplay.Image")));
            this.btDisplay.Location = new System.Drawing.Point(5, 234);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(104, 37);
            this.btDisplay.TabIndex = 3;
            this.btDisplay.Text = "Display";
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(26, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Select the table";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(229, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1107, 530);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cbTable
            // 
            this.cbTable.Location = new System.Drawing.Point(5, 177);
            this.cbTable.Name = "cbTable";
            this.cbTable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.Properties.Appearance.Options.UseFont = true;
            this.cbTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTable.Properties.Items.AddRange(new object[] {
            "CITIZEN",
            "FAMILY REGISTER",
            "LICENSE DRIVE",
            "INSURANCE",
            "SALARY",
            "PASSPORT",
            "LOCATION",
            "CITIZEN LICENSE DRIVE",
            "CITIZEN INSURANCE",
            "CITIZEN SALARY",
            "CITIZEN PASSPORT"});
            this.cbTable.Size = new System.Drawing.Size(218, 26);
            this.cbTable.TabIndex = 0;
            // 
            // ucLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucLog";
            this.Size = new System.Drawing.Size(1341, 534);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btDisplay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btPrint;
        private DevExpress.XtraEditors.ComboBoxEdit cbTable;
    }
}
