namespace CafeteriaSystem
{
    partial class ViewSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSales));
            this.salesGridView1 = new System.Windows.Forms.DataGridView();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillExpens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesGridView1
            // 
            this.salesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillId,
            this.TableId,
            this.BillDate,
            this.BillExpens});
            this.salesGridView1.Location = new System.Drawing.Point(13, 75);
            this.salesGridView1.Name = "salesGridView1";
            this.salesGridView1.Size = new System.Drawing.Size(453, 186);
            this.salesGridView1.TabIndex = 0;
            // 
            // BillId
            // 
            this.BillId.HeaderText = "ID e fatures";
            this.BillId.Name = "BillId";
            // 
            // TableId
            // 
            this.TableId.HeaderText = "ID e tavolines";
            this.TableId.Name = "TableId";
            // 
            // BillDate
            // 
            this.BillDate.HeaderText = "Data";
            this.BillDate.Name = "BillDate";
            // 
            // BillExpens
            // 
            this.BillExpens.HeaderText = "Total (Lek)";
            this.BillExpens.Name = "BillExpens";
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 291);
            this.Controls.Add(this.salesGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSales";
            this.Text = "ViewSales";
            this.Load += new System.EventHandler(this.ViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salesGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillExpens;
    }
}