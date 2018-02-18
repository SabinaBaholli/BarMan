namespace CafeteriaSystem
{
    partial class UpdateTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTables));
            this.tableIdBox = new System.Windows.Forms.TextBox();
            this.tableNamelabel = new System.Windows.Forms.Label();
            this.UpdateTableButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableIdBox
            // 
            this.tableIdBox.Location = new System.Drawing.Point(149, 22);
            this.tableIdBox.Name = "tableIdBox";
            this.tableIdBox.Size = new System.Drawing.Size(150, 20);
            this.tableIdBox.TabIndex = 0;
            this.tableIdBox.TextChanged += new System.EventHandler(this.tableIdBox_TextChanged);
            // 
            // tableNamelabel
            // 
            this.tableNamelabel.AutoSize = true;
            this.tableNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNamelabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tableNamelabel.Location = new System.Drawing.Point(21, 25);
            this.tableNamelabel.Name = "tableNamelabel";
            this.tableNamelabel.Size = new System.Drawing.Size(88, 13);
            this.tableNamelabel.TabIndex = 1;
            this.tableNamelabel.Text = "Id e Tavolinës";
            // 
            // UpdateTableButton
            // 
            this.UpdateTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTableButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UpdateTableButton.Location = new System.Drawing.Point(83, 98);
            this.UpdateTableButton.Name = "UpdateTableButton";
            this.UpdateTableButton.Size = new System.Drawing.Size(133, 23);
            this.UpdateTableButton.TabIndex = 2;
            this.UpdateTableButton.Text = "Ndrysho Tavolinë";
            this.UpdateTableButton.UseVisualStyleBackColor = true;
            this.UpdateTableButton.Click += new System.EventHandler(this.UpdateTableButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Emri i Ri i Tavolinës";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableNameBox
            // 
            this.tableNameBox.Location = new System.Drawing.Point(149, 56);
            this.tableNameBox.Name = "tableNameBox";
            this.tableNameBox.Size = new System.Drawing.Size(150, 20);
            this.tableNameBox.TabIndex = 3;
            this.tableNameBox.TextChanged += new System.EventHandler(this.tableNameBox_TextChanged);
            // 
            // UpdateTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableNameBox);
            this.Controls.Add(this.UpdateTableButton);
            this.Controls.Add(this.tableNamelabel);
            this.Controls.Add(this.tableIdBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateTables";
            this.Text = "Ndrysho Tavolinë";
            this.Load += new System.EventHandler(this.UpdateTables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tableIdBox;
        private System.Windows.Forms.Label tableNamelabel;
        private System.Windows.Forms.Button UpdateTableButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableNameBox;
    }
}