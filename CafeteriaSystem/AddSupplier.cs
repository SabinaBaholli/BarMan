using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
        }

   
      



        private void CategoryNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            bool SupplierAddedOrNot = _DataAccess.AddNewSupplierToDatabase(SupplierNameBox.Text, phoneBox1.Text);

            if (SupplierAddedOrNot)
            {
                MessageBox.Show("Furnitori u shtua");
            }
            else MessageBox.Show("Furnitori nuk u Shtua");
        }
    }
}
