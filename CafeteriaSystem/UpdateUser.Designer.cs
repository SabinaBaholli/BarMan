namespace CafeteriaSystem
{
    partial class UpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUser));
            this.UserName = new System.Windows.Forms.Label();
            this.UserTables = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.rolesTablesGridView1 = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteRole = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditRole = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTablesGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(16, 67);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(27, 13);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Emri";
            // 
            // UserTables
            // 
            this.UserTables.AutoSize = true;
            this.UserTables.Location = new System.Drawing.Point(12, 106);
            this.UserTables.Name = "UserTables";
            this.UserTables.Size = new System.Drawing.Size(51, 13);
            this.UserTables.TabIndex = 2;
            this.UserTables.Text = "Tavolinat";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(101, 67);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(100, 20);
            this.userNameBox.TabIndex = 4;
            // 
            // rolesTablesGridView1
            // 
            this.rolesTablesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesTablesGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.TableId,
            this.newOwner,
            this.deleteRole,
            this.EditRole});
            this.rolesTablesGridView1.Location = new System.Drawing.Point(101, 106);
            this.rolesTablesGridView1.Name = "rolesTablesGridView1";
            this.rolesTablesGridView1.Size = new System.Drawing.Size(547, 176);
            this.rolesTablesGridView1.TabIndex = 5;
            this.rolesTablesGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userTablesGridView1_CellContentClick);
            // 
            // TableName
            // 
            this.TableName.HeaderText = "Emri i tavolines";
            this.TableName.Name = "TableName";
            // 
            // TableId
            // 
            this.TableId.HeaderText = "ID";
            this.TableId.Name = "TableId";
            // 
            // newOwner
            // 
            this.newOwner.HeaderText = "Shto Id e kamarierit te ri pergjegjes per tavolinen";
            this.newOwner.Name = "newOwner";
            // 
            // deleteRole
            // 
            this.deleteRole.HeaderText = "Fshi Rolin";
            this.deleteRole.Name = "deleteRole";
            // 
            // EditRole
            // 
            this.EditRole.HeaderText = "Ndrysho Rolin";
            this.EditRole.Name = "EditRole";
            this.EditRole.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 375);
            this.Controls.Add(this.rolesTablesGridView1);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.UserTables);
            this.Controls.Add(this.UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            ((System.ComponentModel.ISupportInitialize)(this.rolesTablesGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserTables;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.DataGridView rolesTablesGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn newOwner;
        private System.Windows.Forms.DataGridViewButtonColumn deleteRole;
        private System.Windows.Forms.DataGridViewButtonColumn EditRole;
    }
}