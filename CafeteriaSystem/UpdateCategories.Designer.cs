namespace CafeteriaSystem
{
    partial class UpdateCategories
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
        /// the contents of this method with the code editor.s
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCategories));
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameBox = new System.Windows.Forms.TextBox();
            this.UpdateCategoryButton = new System.Windows.Forms.Button();
            this.categoryNamelabel = new System.Windows.Forms.Label();
            this.categoryIdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Emri i Ri i Kategorise";
            // 
            // categoryNameBox
            // 
            this.categoryNameBox.Location = new System.Drawing.Point(131, 70);
            this.categoryNameBox.Name = "categoryNameBox";
            this.categoryNameBox.Size = new System.Drawing.Size(150, 20);
            this.categoryNameBox.TabIndex = 8;
            // 
            // UpdateCategoryButton
            // 
            this.UpdateCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategoryButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UpdateCategoryButton.Location = new System.Drawing.Point(65, 112);
            this.UpdateCategoryButton.Name = "UpdateCategoryButton";
            this.UpdateCategoryButton.Size = new System.Drawing.Size(133, 23);
            this.UpdateCategoryButton.TabIndex = 7;
            this.UpdateCategoryButton.Text = "Ndrysho Kategori";
            this.UpdateCategoryButton.UseVisualStyleBackColor = true;
            this.UpdateCategoryButton.Click += new System.EventHandler(this.UpdateCategoriesButton_Click);
            // 
            // categoryNamelabel
            // 
            this.categoryNamelabel.AutoSize = true;
            this.categoryNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNamelabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.categoryNamelabel.Location = new System.Drawing.Point(3, 39);
            this.categoryNamelabel.Name = "categoryNamelabel";
            this.categoryNamelabel.Size = new System.Drawing.Size(93, 13);
            this.categoryNamelabel.TabIndex = 6;
            this.categoryNamelabel.Text = "Id e Kategorise";
            // 
            // categoryIdBox
            // 
            this.categoryIdBox.Location = new System.Drawing.Point(131, 36);
            this.categoryIdBox.Name = "categoryIdBox";
            this.categoryIdBox.Size = new System.Drawing.Size(150, 20);
            this.categoryIdBox.TabIndex = 5;
            // 
            // UpdateCategories
            // 
            this.ClientSize = new System.Drawing.Size(306, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryNameBox);
            this.Controls.Add(this.UpdateCategoryButton);
            this.Controls.Add(this.categoryNamelabel);
            this.Controls.Add(this.categoryIdBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateCategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryNameBox;
        private System.Windows.Forms.Button UpdateCategoryButton;
        private System.Windows.Forms.Label categoryNamelabel;
        private System.Windows.Forms.TextBox categoryIdBox;
    }
}