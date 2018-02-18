namespace CafeteriaSystem
{
    partial class ViewAllTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllTables));
            this.TablesGroupBox = new System.Windows.Forms.GroupBox();
            this.TablesGridView = new System.Windows.Forms.DataGridView();
            this.TableIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditTableColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteTableColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TablesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TablesGroupBox
            // 
            this.TablesGroupBox.Controls.Add(this.TablesGridView);
            this.TablesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TablesGroupBox.Name = "TablesGroupBox";
            this.TablesGroupBox.Size = new System.Drawing.Size(331, 325);
            this.TablesGroupBox.TabIndex = 3;
            this.TablesGroupBox.TabStop = false;
            this.TablesGroupBox.Text = "Tavolinat";
            // 
            // TablesGridView
            // 
            this.TablesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.TablesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableIDColumn,
            this.TableNameColumn,
            this.Waiter,
            this.EditTableColumn,
            this.DeleteTableColumn});
            this.TablesGridView.Location = new System.Drawing.Point(3, 16);
            this.TablesGridView.Name = "TablesGridView";
            this.TablesGridView.Size = new System.Drawing.Size(328, 309);
            this.TablesGridView.TabIndex = 0;
            this.TablesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablesGridView_CellContentClick);
            // 
            // TableIDColumn
            // 
            this.TableIDColumn.HeaderText = "ID";
            this.TableIDColumn.Name = "TableIDColumn";
            // 
            // TableNameColumn
            // 
            this.TableNameColumn.HeaderText = "Tavolina";
            this.TableNameColumn.Name = "TableNameColumn";
            // 
            // Waiter
            // 
            this.Waiter.HeaderText = "Kamarieri";
            this.Waiter.Name = "Waiter";
            // 
            // EditTableColumn
            // 
            this.EditTableColumn.HeaderText = "Ndrysho";
            this.EditTableColumn.Name = "EditTableColumn";
            this.EditTableColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditTableColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteTableColumn
            // 
            this.DeleteTableColumn.HeaderText = "Fshi";
            this.DeleteTableColumn.Name = "DeleteTableColumn";
            // 
            // ViewAllTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 353);
            this.Controls.Add(this.TablesGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllTables";
            this.Text = "Shiko Tavolinat";
            this.Load += new System.EventHandler(this.ViewAllTables_Load_1);
            this.TablesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TablesGroupBox;
        private System.Windows.Forms.DataGridView TablesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waiter;
        private System.Windows.Forms.DataGridViewButtonColumn EditTableColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteTableColumn;
    }
}