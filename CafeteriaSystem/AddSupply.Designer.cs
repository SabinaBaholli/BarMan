namespace CafeteriaSystem
{
    partial class AddSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupply));
            this.supplyBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.ListaProdukte = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.dateSupply = new System.Windows.Forms.DateTimePicker();
            this.supplierBox = new System.Windows.Forms.ComboBox();
            this.addSupplyButton = new System.Windows.Forms.Button();
            this.supplyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplyBox
            // 
            this.supplyBox.Controls.Add(this.totalLabel);
            this.supplyBox.Controls.Add(this.totalBox);
            this.supplyBox.Controls.Add(this.ItemsGridView);
            this.supplyBox.Controls.Add(this.label1);
            this.supplyBox.Controls.Add(this.supplierLabel);
            this.supplyBox.Controls.Add(this.dateSupply);
            this.supplyBox.Controls.Add(this.supplierBox);
            this.supplyBox.Location = new System.Drawing.Point(10, 11);
            this.supplyBox.Name = "supplyBox";
            this.supplyBox.Size = new System.Drawing.Size(446, 421);
            this.supplyBox.TabIndex = 0;
            this.supplyBox.TabStop = false;
            this.supplyBox.Text = "Furnizim";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.totalLabel.Location = new System.Drawing.Point(66, 386);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(107, 15);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Totali furnizimit";
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(179, 385);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(221, 20);
            this.totalBox.TabIndex = 5;
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListaProdukte,
            this.QuantityColumn,
            this.PriceColumn});
            this.ItemsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ItemsGridView.Location = new System.Drawing.Point(25, 63);
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.Size = new System.Drawing.Size(395, 309);
            this.ItemsGridView.TabIndex = 4;
            this.ItemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGridView_CellContentClick);
            this.ItemsGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ndryshoTotali);
            // 
            // ListaProdukte
            // 
            this.ListaProdukte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ListaProdukte.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ListaProdukte.HeaderText = "Produkti";
            this.ListaProdukte.Name = "ListaProdukte";
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantityColumn.HeaderText = "Sasia";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceColumn
            // 
            this.PriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceColumn.HeaderText = "Çmimi";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(249, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.supplierLabel.Location = new System.Drawing.Point(24, 29);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(61, 15);
            this.supplierLabel.TabIndex = 2;
            this.supplierLabel.Text = "Furnitori";
            this.supplierLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateSupply
            // 
            this.dateSupply.Location = new System.Drawing.Point(288, 26);
            this.dateSupply.Name = "dateSupply";
            this.dateSupply.Size = new System.Drawing.Size(132, 20);
            this.dateSupply.TabIndex = 1;
            // 
            // supplierBox
            // 
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(89, 26);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(121, 21);
            this.supplierBox.TabIndex = 0;
            this.supplierBox.SelectedIndexChanged += new System.EventHandler(this.supplierBox_SelectedIndexChanged);
            // 
            // addSupplyButton
            // 
            this.addSupplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplyButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.addSupplyButton.Location = new System.Drawing.Point(161, 455);
            this.addSupplyButton.Name = "addSupplyButton";
            this.addSupplyButton.Size = new System.Drawing.Size(113, 23);
            this.addSupplyButton.TabIndex = 7;
            this.addSupplyButton.Text = "Shto Furnizim";
            this.addSupplyButton.UseVisualStyleBackColor = true;
            this.addSupplyButton.Click += new System.EventHandler(this.addSupplyButton_Click);
            // 
            // AddSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 490);
            this.Controls.Add(this.addSupplyButton);
            this.Controls.Add(this.supplyBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSupply";
            this.Text = "Shto Furnizim";
            this.Load += new System.EventHandler(this.AddSupply_Load);
            this.supplyBox.ResumeLayout(false);
            this.supplyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox supplyBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.DateTimePicker dateSupply;
        private System.Windows.Forms.ComboBox supplierBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button addSupplyButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn ListaProdukte;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
    }
}