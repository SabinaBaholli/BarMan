using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class ViewAllSupplies : Form
    {
        public ViewAllSupplies()
        {
            InitializeComponent();
        }

        private void ViewAllSupplies_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Supply SupplyDetail in _DataAccess.RetreiveAllSupplies())
            {
                dataGridView1.Rows.Add(SupplyDetail.Id, SupplyDetail.Item, SupplyDetail.Quantity, SupplyDetail.Supplier, SupplyDetail.Date);

                if (!comboBox2.Items.Contains(SupplyDetail.Id))
                {
                    comboBox2.Items.Add(SupplyDetail.Id);
                }

                if (!comboBox1.Items.Contains(SupplyDetail.Supplier))
                {
                    comboBox1.Items.Add(SupplyDetail.Supplier);
                }
            }

           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
