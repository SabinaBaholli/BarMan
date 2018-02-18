using System;
using System.Windows.Forms;
using CafeteriaSystem.models;
using System.Collections;
using System.Configuration;
using System.Data;

namespace CafeteriaSystem
{
    public partial class AddSupply : Form
    {
        string supplierId;
        public AddSupply()
        {
            InitializeComponent();
          
            DataAccess DA = new DataAccess();

            ArrayList prods = DA.RetreiveAllProducts();
            ArrayList supps = DA.RetreiveAllSuppliersFromDatabase();

            ListaProdukte.DataSource = prods;
            ListaProdukte.DisplayMember = "Name";
            ListaProdukte.ValueMember = "Id";

            supplierBox.DataSource = supps;
            supplierBox.DisplayMember = "Name";
            supplierBox.ValueMember = "ID";


         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddSupply_Load(object sender, EventArgs e)
        {

        }

        private void ndryshoTotali(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < ItemsGridView.Rows.Count; ++i)
            {
                int mult = Convert.ToInt32(ItemsGridView.Rows[i].Cells[1].Value) * Convert.ToInt32(ItemsGridView.Rows[i].Cells[2].Value);
                sum += mult;
            }
            totalBox.Text = sum.ToString();
        }

        private void supplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addSupplyButton_Click(object sender, EventArgs e)
        {
            
            DataAccess DA = new DataAccess();

            DateTime thisDay = DateTime.Now;
            foreach (DataGridViewRow row in ItemsGridView.Rows)
            {
                if (row.Cells["ListaProdukte"].Value != null) //workflow to avoid automatically added new row
                {
                    supplierId = supplierBox.SelectedValue.ToString();
                int itemQuantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                int itemPrice = Convert.ToInt32(row.Cells["PriceColumn"].Value);
                string itemId = row.Cells["ListaProdukte"].Value.ToString();
                if (DA.AddSupply(supplierId, thisDay, itemId, itemQuantity, itemPrice))
                  {
                   MessageBox.Show("Furnizimi u shtua!");
                  }

                }
            }

        }
    }
}
