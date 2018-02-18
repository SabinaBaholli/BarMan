namespace CafeteriaSystem
{
    partial class UpdateSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSuppliers));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierNameBox1 = new System.Windows.Forms.TextBox();
            this.supplierPhoneBox1 = new System.Windows.Forms.TextBox();
            this.supplierUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            // 
            // supplierNameBox1
            // 
            this.supplierNameBox1.Location = new System.Drawing.Point(127, 28);
            this.supplierNameBox1.Name = "supplierNameBox1";
            this.supplierNameBox1.Size = new System.Drawing.Size(100, 20);
            this.supplierNameBox1.TabIndex = 3;
            // 
            // supplierPhoneBox1
            // 
            this.supplierPhoneBox1.Location = new System.Drawing.Point(127, 67);
            this.supplierPhoneBox1.Name = "supplierPhoneBox1";
            this.supplierPhoneBox1.Size = new System.Drawing.Size(100, 20);
            this.supplierPhoneBox1.TabIndex = 4;
            // 
            // supplierUpdate
            // 
            this.supplierUpdate.Location = new System.Drawing.Point(95, 135);
            this.supplierUpdate.Name = "supplierUpdate";
            this.supplierUpdate.Size = new System.Drawing.Size(75, 23);
            this.supplierUpdate.TabIndex = 5;
            this.supplierUpdate.Text = "Ndrysho";
            this.supplierUpdate.UseVisualStyleBackColor = true;
            this.supplierUpdate.Click += new System.EventHandler(this.supplierUpdate_Click);
            // 
            // UpdateSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.supplierUpdate);
            this.Controls.Add(this.supplierPhoneBox1);
            this.Controls.Add(this.supplierNameBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSuppliers";
            this.Text = "UpdateSuppliers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplierNameBox1;
        private System.Windows.Forms.TextBox supplierPhoneBox1;
        private System.Windows.Forms.Button supplierUpdate;
    }
}