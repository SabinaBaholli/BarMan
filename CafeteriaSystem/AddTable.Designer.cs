namespace CafeteriaSystem
{
    partial class AddTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTable));
            this.label1 = new System.Windows.Forms.Label();
            this.AddTableButton = new System.Windows.Forms.Button();
            this.TableNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kamarierComboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emri i Tavolines";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddTableButton
            // 
            this.AddTableButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTableButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddTableButton.Location = new System.Drawing.Point(71, 146);
            this.AddTableButton.Name = "AddTableButton";
            this.AddTableButton.Size = new System.Drawing.Size(130, 23);
            this.AddTableButton.TabIndex = 8;
            this.AddTableButton.Text = "Shto Tavolinë";
            this.AddTableButton.UseVisualStyleBackColor = true;
            this.AddTableButton.Click += new System.EventHandler(this.AddTableButton_Click_1);
            // 
            // TableNameBox
            // 
            this.TableNameBox.Location = new System.Drawing.Point(130, 29);
            this.TableNameBox.Name = "TableNameBox";
            this.TableNameBox.Size = new System.Drawing.Size(158, 20);
            this.TableNameBox.TabIndex = 9;
            this.TableNameBox.TextChanged += new System.EventHandler(this.TableNameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kamarieri";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kamarierComboBox1
            // 
            this.kamarierComboBox1.FormattingEnabled = true;
            this.kamarierComboBox1.Location = new System.Drawing.Point(130, 79);
            this.kamarierComboBox1.Name = "kamarierComboBox1";
            this.kamarierComboBox1.Size = new System.Drawing.Size(158, 21);
            this.kamarierComboBox1.TabIndex = 11;
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 202);
            this.Controls.Add(this.kamarierComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableNameBox);
            this.Controls.Add(this.AddTableButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto Tavoline";
            this.Load += new System.EventHandler(this.AddTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTableButton;
        private System.Windows.Forms.TextBox TableNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kamarierComboBox1;
    }
}