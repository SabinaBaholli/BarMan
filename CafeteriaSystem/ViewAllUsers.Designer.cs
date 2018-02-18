namespace CafeteriaSystem
{
    partial class ViewAllUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllUsers));
            this.usersGridView1 = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditUser = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGridView1
            // 
            this.usersGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.EditUser});
            this.usersGridView1.Location = new System.Drawing.Point(24, 12);
            this.usersGridView1.Name = "usersGridView1";
            this.usersGridView1.Size = new System.Drawing.Size(589, 441);
            this.usersGridView1.TabIndex = 0;
            this.usersGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView1_CellContentClick);
            // 
            // UserId
            // 
            this.UserId.HeaderText = "ID";
            this.UserId.Name = "UserId";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Emri";
            this.UserName.Name = "UserName";
            // 
            // EditUser
            // 
            this.EditUser.HeaderText = "Shiko/Ndrysho Tavolinat";
            this.EditUser.Name = "EditUser";
            this.EditUser.Width = 150;
            // 
            // ViewAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 465);
            this.Controls.Add(this.usersGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllUsers";
            this.Text = "ViewAllUsers";
            this.Load += new System.EventHandler(this.ViewAllUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewButtonColumn EditUser;
    }
}