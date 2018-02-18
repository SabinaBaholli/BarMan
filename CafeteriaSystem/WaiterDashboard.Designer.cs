namespace CafeteriaSystem
{
    partial class WaiterDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterDashboard));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hyrjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNameIDMenuLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.SuppliersFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.categoriesList = new System.Windows.Forms.ComboBox();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BillGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TablesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TotalBillLabel = new System.Windows.Forms.Label();
            this.DailySaleButton = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.CategoryGroupBox.SuspendLayout();
            this.SuppliersFlowPanel.SuspendLayout();
            this.ProductsGroupBox.SuspendLayout();
            this.BillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.UserNameIDMenuLabel});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(15, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(1290, 40);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            this.MainMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenuStrip_ItemClicked);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackgroundImage = global::CafeteriaSystem.Properties.Resources.rounded_rectangle1;
            this.reportsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hyrjeToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.reportsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.reportsToolStripMenuItem.Text = "Raporte";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // hyrjeToolStripMenuItem
            // 
            this.hyrjeToolStripMenuItem.Name = "hyrjeToolStripMenuItem";
            this.hyrjeToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.hyrjeToolStripMenuItem.Text = "Hyrje";
            // 
            // UserNameIDMenuLabel
            // 
            this.UserNameIDMenuLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserNameIDMenuLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserNameIDMenuLabel.CheckOnClick = true;
            this.UserNameIDMenuLabel.DoubleClickEnabled = true;
            this.UserNameIDMenuLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.UserNameIDMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameIDMenuLabel.Image = global::CafeteriaSystem.Properties.Resources.UserIcon;
            this.UserNameIDMenuLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNameIDMenuLabel.Name = "UserNameIDMenuLabel";
            this.UserNameIDMenuLabel.Size = new System.Drawing.Size(54, 36);
            this.UserNameIDMenuLabel.Text = " ";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Controls.Add(this.SuppliersFlowPanel);
            this.CategoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CategoryGroupBox.Location = new System.Drawing.Point(342, 44);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Size = new System.Drawing.Size(540, 87);
            this.CategoryGroupBox.TabIndex = 1;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Kategorite";
            // 
            // SuppliersFlowPanel
            // 
            this.SuppliersFlowPanel.AutoScroll = true;
            this.SuppliersFlowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SuppliersFlowPanel.Controls.Add(this.categoriesList);
            this.SuppliersFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuppliersFlowPanel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SuppliersFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.SuppliersFlowPanel.Name = "SuppliersFlowPanel";
            this.SuppliersFlowPanel.Size = new System.Drawing.Size(534, 68);
            this.SuppliersFlowPanel.TabIndex = 0;
            // 
            // categoriesList
            // 
            this.categoriesList.AllowDrop = true;
            this.categoriesList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.categoriesList.DropDownHeight = 200;
            this.categoriesList.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.IntegralHeight = false;
            this.categoriesList.ItemHeight = 24;
            this.categoriesList.Location = new System.Drawing.Point(3, 3);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(528, 32);
            this.categoriesList.Sorted = true;
            this.categoriesList.TabIndex = 0;
            this.categoriesList.SelectedIndexChanged += new System.EventHandler(this.categoriesList_SelectedIndexChanged);
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.ProductsFlowPanel);
            this.ProductsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ProductsGroupBox.Location = new System.Drawing.Point(343, 137);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(539, 416);
            this.ProductsGroupBox.TabIndex = 2;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "Produktet";
            this.ProductsGroupBox.Enter += new System.EventHandler(this.ProductsGroupBox_Enter);
            // 
            // ProductsFlowPanel
            // 
            this.ProductsFlowPanel.AutoScroll = true;
            this.ProductsFlowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProductsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsFlowPanel.ForeColor = System.Drawing.SystemColors.Info;
            this.ProductsFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.ProductsFlowPanel.Name = "ProductsFlowPanel";
            this.ProductsFlowPanel.Size = new System.Drawing.Size(533, 397);
            this.ProductsFlowPanel.TabIndex = 0;
            this.ProductsFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductsFlowPanel_Paint);
            // 
            // BillGroupBox
            // 
            this.BillGroupBox.Controls.Add(this.ProductsGridView);
            this.BillGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGroupBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BillGroupBox.Location = new System.Drawing.Point(891, 37);
            this.BillGroupBox.Name = "BillGroupBox";
            this.BillGroupBox.Size = new System.Drawing.Size(381, 437);
            this.BillGroupBox.TabIndex = 3;
            this.BillGroupBox.TabStop = false;
            this.BillGroupBox.Text = "Fatura";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductQuantityColumn,
            this.TotalPriceColumn,
            this.DeleteColumn});
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ProductsGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(375, 418);
            this.ProductsGridView.TabIndex = 0;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            this.ProductsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellEndEdit);
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductIDColumn.FillWeight = 50F;
            this.ProductIDColumn.HeaderText = "ID";
            this.ProductIDColumn.Name = "ProductIDColumn";
            this.ProductIDColumn.Width = 30;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Artikulli";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Cmimi";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductQuantityColumn.HeaderText = "Sasia";
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            this.ProductQuantityColumn.Width = 30;
            // 
            // TotalPriceColumn
            // 
            this.TotalPriceColumn.HeaderText = "Shuma";
            this.TotalPriceColumn.Name = "TotalPriceColumn";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteColumn.HeaderText = "Fshi";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Width = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(903, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Totali";
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(132)))), ((int)(((byte)(169)))));
            this.CheckOutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.Location = new System.Drawing.Point(982, 514);
            this.CheckOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(127, 30);
            this.CheckOutButton.TabIndex = 6;
            this.CheckOutButton.Text = "Perfundo Fature";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.TablesFlowPanel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(14, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 510);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tavolinat";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TablesFlowPanel
            // 
            this.TablesFlowPanel.AutoScroll = true;
            this.TablesFlowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TablesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.TablesFlowPanel.Name = "TablesFlowPanel";
            this.TablesFlowPanel.Size = new System.Drawing.Size(316, 491);
            this.TablesFlowPanel.TabIndex = 0;
            this.TablesFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablesFlowPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(132)))), ((int)(((byte)(169)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(902, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ruaj";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(132)))), ((int)(((byte)(169)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1200, 514);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Printo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TotalBillLabel
            // 
            this.TotalBillLabel.AutoSize = true;
            this.TotalBillLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TotalBillLabel.Location = new System.Drawing.Point(983, 474);
            this.TotalBillLabel.Name = "TotalBillLabel";
            this.TotalBillLabel.Size = new System.Drawing.Size(65, 28);
            this.TotalBillLabel.TabIndex = 9;
            this.TotalBillLabel.Text = "Totali";
            // 
            // DailySaleButton
            // 
            this.DailySaleButton.Location = new System.Drawing.Point(94, 12);
            this.DailySaleButton.Name = "DailySaleButton";
            this.DailySaleButton.Size = new System.Drawing.Size(128, 23);
            this.DailySaleButton.TabIndex = 10;
            this.DailySaleButton.Text = "Xhiro e dites";
            this.DailySaleButton.UseVisualStyleBackColor = true;
            this.DailySaleButton.Click += new System.EventHandler(this.DailySaleButton_Click);
            // 
            // WaiterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 562);
            this.Controls.Add(this.DailySaleButton);
            this.Controls.Add(this.TotalBillLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillGroupBox);
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.CategoryGroupBox);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaiterDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menaxhim Bar-Kafe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.CategoryGroupBox.ResumeLayout(false);
            this.SuppliersFlowPanel.ResumeLayout(false);
            this.ProductsGroupBox.ResumeLayout(false);
            this.BillGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.FlowLayoutPanel SuppliersFlowPanel;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowPanel;
        private System.Windows.Forms.GroupBox BillGroupBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.ToolStripMenuItem UserNameIDMenuLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel TablesFlowPanel;
        private System.Windows.Forms.ComboBox categoriesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem hyrjeToolStripMenuItem;
        private System.Windows.Forms.Label TotalBillLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button DailySaleButton;
    }
}

