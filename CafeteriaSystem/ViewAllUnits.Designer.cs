namespace CafeteriaSystem
{
    partial class ViewAllUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllUnits));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unitGridView1 = new System.Windows.Forms.DataGridView();
            this.UnitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteUnitColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditUnitColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unitGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Njësite";
            // 
            // unitGridView1
            // 
            this.unitGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitIdColumn,
            this.UnitNameColumn,
            this.DeleteUnitColumn,
            this.EditUnitColumn});
            this.unitGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitGridView1.Location = new System.Drawing.Point(3, 16);
            this.unitGridView1.Name = "unitGridView1";
            this.unitGridView1.Size = new System.Drawing.Size(274, 184);
            this.unitGridView1.TabIndex = 0;
            this.unitGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.unitGridView1_CellContentClick);
            // 
            // UnitIdColumn
            // 
            this.UnitIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitIdColumn.HeaderText = "Njësi Id";
            this.UnitIdColumn.Name = "UnitIdColumn";
            // 
            // UnitNameColumn
            // 
            this.UnitNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitNameColumn.HeaderText = "Emri i Njësisë";
            this.UnitNameColumn.Name = "UnitNameColumn";
            // 
            // DeleteUnitColumn
            // 
            this.DeleteUnitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteUnitColumn.HeaderText = "Fshi";
            this.DeleteUnitColumn.Name = "DeleteUnitColumn";
            // 
            // EditUnitColumn
            // 
            this.EditUnitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditUnitColumn.HeaderText = "Ndrysho";
            this.EditUnitColumn.Name = "EditUnitColumn";
            // 
            // ViewAllUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllUnits";
            this.Text = "ViewAllUnits";
            this.Load += new System.EventHandler(this.ViewAllUnits_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView unitGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteUnitColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditUnitColumn;
    }
}