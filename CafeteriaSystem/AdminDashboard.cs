using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class AdminDashboard : Form
    {


        public AdminDashboard(int UserID, ApplicationState AppState)
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

        public decimal CalculateTotalBill(DataGridView ProductsGridView)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        private void viewAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllProducts().ShowDialog();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllSales().ShowDialog();
        }

       
        private void ProductsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
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
        }

      
        private void ProductsGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void administrationToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (administrationToolStripMenuItem.Checked == true)
                administrationToolStripMenuItem.ForeColor = Color.Red;
        }

        private void addTableToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddTable _AddTable = new AddTable();
            _AddTable.ShowDialog();
        }

        private void deleteTableToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new ViewAllTables().ShowDialog();
        }

        private void shikoFurnizimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllSupplies().ShowDialog();
        }

        private void fshiKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllCategories().ShowDialog();
        }

        private void addCategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddCategory _AddCategory = new AddCategory();
            _AddCategory.ShowDialog();
        }

        private void viewAllProductsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new ViewAllProducts().ShowDialog();
        }

        private void addProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddProduct _AddProduct = new AddProduct();
            _AddProduct.ShowDialog();
        }

        private void shikoNjësitëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllUnits().ShowDialog();
        }

        private void shtoNjësiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUnit _AddUnit = new AddUnit();
            _AddUnit.ShowDialog();
        }

        private void shtoFurnizimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupply _AddSupply = new AddSupply();
            _AddSupply.ShowDialog();
        }

        private void shikoNiveletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllRoles().ShowDialog();
        }

        private void shtoNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRole _AddRole = new AddRole();
            _AddRole.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shtoFurnitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier _AddSupply = new AddSupplier();
            _AddSupply.ShowDialog();
        }

        private void shikoFurnitoretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllSuppliers().ShowDialog();
        }

        private void shikoStatusetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menaxhoPerdoruesitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllUsers().ShowDialog();

        }

        private void hyrjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewStock().ShowDialog();
        }

        private void ViewSales_Click(object sender, EventArgs e)
        {
            new ViewSales().ShowDialog();
           }
    }
}