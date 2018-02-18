namespace CafeteriaSystem
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.label1 = new System.Windows.Forms.Label();
            this.SupplierNameBox = new System.Windows.Forms.TextBox();
            this.AddSupplierButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emri i Furnitorit";
            // 
            // SupplierNameBox
            // 
            this.SupplierNameBox.Location = new System.Drawing.Point(138, 25);
            this.SupplierNameBox.Name = "SupplierNameBox";
            this.SupplierNameBox.Size = new System.Drawing.Size(146, 20);
            this.SupplierNameBox.TabIndex = 3;
            // 
            // AddSupplierButton
            // 
            this.AddSupplierButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddSupplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplierButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddSupplierButton.Location = new System.Drawing.Point(93, 157);
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.AddSupplierButton.Size = new System.Drawing.Size(130, 23);
            this.AddSupplierButton.TabIndex = 7;
            this.AddSupplierButton.Text = "Shto Furnitor";
            this.AddSupplierButton.UseVisualStyleBackColor = true;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefon";
            // 
            // phoneBox1
            // 
            this.phoneBox1.Location = new System.Drawing.Point(138, 65);
            this.phoneBox1.Name = "phoneBox1";
            this.phoneBox1.Size = new System.Drawing.Size(146, 20);
            this.phoneBox1.TabIndex = 9;
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 203);
            this.Controls.Add(this.phoneBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddSupplierButton);
            this.Controls.Add(this.SupplierNameBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shto Furnitor";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SupplierNameBox;
        private System.Windows.Forms.Button AddSupplierButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneBox1;
    }
}