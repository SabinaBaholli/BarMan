namespace CafeteriaSystem
{
    partial class ViewAllSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllSuppliers));
            this.supplierGridView1 = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditSupplier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteSupplier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.furnitorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierGridView1
            // 
            this.supplierGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupplierName,
            this.SupplierPhone,
            this.EditSupplier,
            this.DeleteSupplier});
            this.supplierGridView1.Location = new System.Drawing.Point(48, 48);
            this.supplierGridView1.Name = "supplierGridView1";
            this.supplierGridView1.Size = new System.Drawing.Size(546, 210);
            this.supplierGridView1.TabIndex = 0;
            this.supplierGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierGridView1_CellContentClick);
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "ID";
            this.SupplierId.Name = "SupplierId";
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Emri";
            this.SupplierName.Name = "SupplierName";
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.HeaderText = "Phone Number";
            this.SupplierPhone.Name = "SupplierPhone";
            // 
            // EditSupplier
            // 
            this.EditSupplier.HeaderText = "Ndrysho";
            this.EditSupplier.Name = "EditSupplier";
            this.EditSupplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteSupplier
            // 
            this.DeleteSupplier.HeaderText = "Fshi";
            this.DeleteSupplier.Name = "DeleteSupplier";
            this.DeleteSupplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // furnitorLabel1
            // 
            this.furnitorLabel1.AutoSize = true;
            this.furnitorLabel1.Location = new System.Drawing.Point(12, 13);
            this.furnitorLabel1.Name = "furnitorLabel1";
            this.furnitorLabel1.Size = new System.Drawing.Size(51, 13);
            this.furnitorLabel1.TabIndex = 1;
            this.furnitorLabel1.Text = "Furnitoret";
            // 
            // ViewAllSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 310);
            this.Controls.Add(this.furnitorLabel1);
            this.Controls.Add(this.supplierGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllSuppliers";
            this.Text = "ViewAllSuppliers";
            this.Load += new System.EventHandler(this.ViewAllSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView supplierGridView1;
        private System.Windows.Forms.Label furnitorLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierPhone;
        private System.Windows.Forms.DataGridViewButtonColumn EditSupplier;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteSupplier;
    }
}