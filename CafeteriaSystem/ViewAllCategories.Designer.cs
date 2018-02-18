namespace CafeteriaSystem
{
    partial class ViewAllCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllCategories));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoriesGridView1 = new System.Windows.Forms.DataGridView();
            this.CategoryIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCategoryColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteCategoryColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoriesGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorite";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // categoriesGridView1
            // 
            this.categoriesGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryIdColumn,
            this.CategoryNameColumn,
            this.EditCategoryColumn,
            this.DeleteCategoryColumn});
            this.categoriesGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesGridView1.Location = new System.Drawing.Point(3, 16);
            this.categoriesGridView1.Name = "categoriesGridView1";
            this.categoriesGridView1.Size = new System.Drawing.Size(317, 306);
            this.categoriesGridView1.TabIndex = 0;
            this.categoriesGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesGridView1_CellContentClick);
            // 
            // CategoryIdColumn
            // 
            this.CategoryIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryIdColumn.HeaderText = "Id e Kategorise";
            this.CategoryIdColumn.Name = "CategoryIdColumn";
            // 
            // CategoryNameColumn
            // 
            this.CategoryNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryNameColumn.HeaderText = "Emri i Kategorise";
            this.CategoryNameColumn.Name = "CategoryNameColumn";
            // 
            // EditCategoryColumn
            // 
            this.EditCategoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditCategoryColumn.HeaderText = "Ndrysho Kategori";
            this.EditCategoryColumn.Name = "EditCategoryColumn";
            // 
            // DeleteCategoryColumn
            // 
            this.DeleteCategoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteCategoryColumn.HeaderText = "Fshi Kategori";
            this.DeleteCategoryColumn.Name = "DeleteCategoryColumn";
            // 
            // ViewAllCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 329);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllCategories";
            this.Text = "ViewAllCategories";
            this.Load += new System.EventHandler(this.ViewAllCategories_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditCategoryColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCategoryColumn;
        public System.Windows.Forms.DataGridView categoriesGridView1;
    }
}