using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CafeteriaSystem
{
    public partial class WaiterDashboard : Form
    {


        public WaiterDashboard(int UserID, ApplicationState AppState)
        {
            InitializeComponent();

            SalesmanID = UserID;

            DataAccess _DataAccess = new DataAccess();

            Username = _DataAccess.ReturnUserName(UserID);

            State = AppState;
        }

        public int SalesmanID = 0;
        public string Username = string.Empty;
        public ApplicationState State = null;

        public int RowIndex = 0;

        /*---- Dashboard load ----*/
        private void Dashboard_Load(object sender, EventArgs e)
        {
            UserNameIDMenuLabel.Text = Username;

            DataAccess _DataAccess = new DataAccess();

            ArrayList AllCategories = _DataAccess.RetreiveAllCategoriesFromDatabase();
            foreach (Category category in AllCategories)
            {
                categoriesList.Items.Add(category);
            }

            // ApplicationState State = _DataAccess.GetState();
            Render();
        }

        void Render()
        {
            TablesFlowPanel.Controls.Clear();
            foreach (Table table in State.Tables)
            {
                if (table.Owner == SalesmanID)
                {

                    Button TableButton = new Button();
                    TableButton.Text = table.Name;
                    TableButton.Size = new System.Drawing.Size(80, 80);
                    TableButton.ForeColor = Color.White;
                    TableButton.BackColor = table.GetColor();

                    TableButton.Tag = table.Id;
                    TableButton.Click += TableButton_Click;

                    TablesFlowPanel.Controls.Add(TableButton);
                }
            }

            RenderBill();

        }

        void RenderBill()
        {
            Table selectedTable = State.GetSelectedTable();
            ProductsGridView.Rows.Clear();
            if (selectedTable.Bill != null)
            {
                foreach (Item item in selectedTable.Bill.Items)
                {
                    ProductsGridView.Rows.Add(item.Id, item.Name, item.Price, item.Quantity, item.Price * item.Quantity);
                }
            }


            TotalBillLabel.Text = State.GetTotal() + " Leke";

        }

        void ProductButton_Click(object sender, EventArgs e)
        {
            Button ProductButton = sender as Button;

            DataAccess _DataAccess = new DataAccess();
            Table SelectedTable = State.GetSelectedTable();

            int ProductID = Convert.ToInt32(ProductButton.Tag);

            if(SelectedTable.Bill != null)
            {
                State.AddItem(ProductID);
            } else
            {
                MessageBox.Show("Ju lutem, zgjidhni nje tavoline me pare!");
            }
            

            Render();
        }

        void TableButton_Click(object sender, EventArgs e)
        {
            Button TableButton = sender as Button;

            State.SetActiveTable((int)TableButton.Tag);

            Render();
        }

        private void categoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductsFlowPanel.Controls.Clear();

            ComboBox senderComboBox = (ComboBox)sender;

            int CategoryID = Convert.ToInt32(((Category)senderComboBox.SelectedItem).ID);

            DataAccess _DataAccess = new DataAccess();

            foreach (Details Product in _DataAccess.RetreiveProductsFromCategory(CategoryID))
            {
                Button ProductButton = new Button();
                ProductButton.Text = Product.Name;
                ProductButton.Size = new System.Drawing.Size(125, 125);
                ProductButton.ForeColor = Color.White;


                ProductButton.Tag = Product.ID;

                ProductsFlowPanel.Controls.Add(ProductButton);

                ProductButton.Click += ProductButton_Click;

                //ProductButton.MouseClick += ProductButton_MouseClick;
            }
        }

        void CategoryButtonClick(object sender, EventArgs e)
        {

        }

        void ProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            //for loweing one quantity. do this.. <---------------------
            switch (e.Button)
            {
                case MouseButtons.Right:
                    MessageBox.Show("Right Click");
                    break;
                case MouseButtons.Left:
                    MessageBox.Show("Left Click");
                    break;
            }
        }

        public bool CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                if (Convert.ToInt32(Row.Cells["ProductIDColumn"].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }


        /** Add Category Item **/
        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory _AddCategory = new AddCategory();

            //Retreive CatgeoriesAgain to Show on SuppliersFlow Panel

            if (_AddCategory.ShowDialog() == DialogResult.OK)
            {
                SuppliersFlowPanel.Controls.Clear();

                DataAccess _DataAccess = new DataAccess();

                ArrayList AllSuppliers = _DataAccess.RetreiveAllSuppliersFromDatabase();

                foreach (Category Category in AllSuppliers)
                {
                    Button btn = new Button();
                    btn.Text = Category.Name;
                    btn.Size = new System.Drawing.Size(80, 80);
                    btn.ForeColor = Color.White;

                    btn.Tag = Category.ID;

                    SuppliersFlowPanel.Controls.Add(btn);

                    btn.Click += CategoryButtonClick;
                }
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct _AddProduct = new AddProduct();
            _AddProduct.ShowDialog();
        }

        private void viewAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllProducts().ShowDialog();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllSales().ShowDialog();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            CashForm _CashForm = new CashForm();

            _CashForm.TotalBillBox.Text = State.GetTotal().ToString();

            if (_CashForm.ShowDialog() == DialogResult.OK)
            {
                if(State.PersistBill(SalesmanID, 2, _CashForm.TotalBillBox.Text)){ 

                ArrayList ProductsList = new ArrayList();

                MessageBox.Show("Fatura u ruajt me sukses!");
                }

                DataAccess _DA = new DataAccess();

                State = _DA.GetState();

                Render();

            }
        }

        private void ProductsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    if (MessageBox.Show("Jeni i sigurt qe do ta fshish kete produkt?", "Kujdes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ItemId = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value);

                        State.RemoveItem(ItemId);

                        Render();
                    }
                }
            }
        }

        /// <summary>
        /// Persist BIll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal Total = 0;

            for (int i = 0; i < ProductsGridView.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(ProductsGridView.Rows[i].Cells["TotalPriceColumn"].Value);
            }


            if(State.PersistBill(SalesmanID, 1, Total.ToString())) { 
            DataAccess _DA = new DataAccess();
            State = _DA.GetState();
            Render();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProductsFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void MainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void administrationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void shtoTavolinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regjistoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register _Register = new Register();
            this.Hide();
            _Register.Show();
        }

        private void TablesFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTable _AddTable = new AddTable();

            
            _AddTable.ShowDialog();

            //Retreive TablesAgain to Show on SuppliersFlow Panel

            if (_AddTable.ShowDialog() == DialogResult.OK)
             { 
                 SuppliersFlowPanel.Controls.Clear();

                 DataAccess _DataAccess = new DataAccess();

                 ArrayList AllTables = _DataAccess.RetreiveAllTables();

                 foreach (Table Table in AllTables)
                 {
                     Button TableButton = new Button();
                     TableButton.Text = Table.Name;
                     TableButton.Size = new System.Drawing.Size(90, 90);
                     TableButton.ForeColor = Color.White;
                     TableButton.BackColor = Table.GetColor();

                     TableButton.Tag = Table.Id;
                     TableButton.Click += TableButton_Click;

                     TablesFlowPanel.Controls.Add(TableButton);
                 } 
        }
        }

        private void deleteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllTables().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        { //Create document
            string path = @"C:\Users\erisa\Desktop\DETYRA\fatura-1.pdf";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();
            PdfPTable table = new PdfPTable(3);

            PdfPCell cell = new PdfPCell(new Phrase("Fature"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            foreach (Item item in State.GetSelectedTable().Bill.Items)
            {
                table.AddCell(item.Name);
                table.AddCell(item.Quantity.ToString());
                table.AddCell((item.Quantity * item.Price).ToString());
            }

            cell = new PdfPCell(new Phrase("Totali"));
            cell.Colspan = 2;
            table.AddCell(cell);
            table.AddCell(State.GetTotal().ToString() + " Leke");


            document.Add(table);
            System.Diagnostics.Process.Start(path);
            document.Close();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void DailySaleButton_Click(object sender, EventArgs e)
        {
            int Total = 0;
            DataAccess _DataAccess = new DataAccess();

            ArrayList daySails = _DataAccess.RetreiveDailySales();
            if (daySails.Count == 0)
            {
                MessageBox.Show("Nuk eshte shitur asnje produkt!");
                return;
            }
            string path = @"C:\Users\erisa\Desktop\DETYRA\xhiro-1.pdf";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();
            PdfPTable table = new PdfPTable(2);

            PdfPCell cell = new PdfPCell(new Phrase("Xhiro ditore"));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);


            cell.Colspan = 2;
            table.AddCell("Shuma");
            table.AddCell("Koha");



            foreach (Bill bill in daySails)
            {
                cell.Colspan = 2;
                table.AddCell(bill.Shpenzimet.ToString());
                table.AddCell(bill.Date.ToString());
                Total += bill.Shpenzimet;
            }

            cell.Colspan = 2;
            table.AddCell("Totali");
            table.AddCell(Total.ToString() + " Lek");


            document.Add(table);
            System.Diagnostics.Process.Start(path);
            document.Close();

        }
    }
}