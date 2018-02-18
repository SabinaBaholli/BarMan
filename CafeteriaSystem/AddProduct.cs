using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Category Category in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                ProductCategoryComboBox.Items.Add(Category.Name);
            }

            foreach (Unit Unit in _DataAccess.RetreiveAllUnitsFromDatabase())
            {
                unitBox.Items.Add(Unit.Name);
            }
        }

      

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            /*THIS IS THE MAIN CODE FOR HASHING*/

            /*initializing memory stream class for creating a stream of binary numbers*/
            //  MemoryStream ms = new MemoryStream();

            /*saving the image in raw format from picture box*/
            //   ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat);

            /*Array of Binary numbers that have been converted*/
            //   byte[] ProductPicture = ms.GetBuffer();

            /*closing the memory stream*/
            //    ms.Close();

            /*HASHING END HERE*/
            string CategoryName = ProductCategoryComboBox.SelectedItem.ToString();
            string unitName = unitBox.SelectedItem.ToString();

            if (_DataAccess.AddNewProductToDatabase(ProductNameBox.Text, Convert.ToDecimal(ProductPriceBox.Text), _DataAccess.ReturnCategoryID(CategoryName), _DataAccess.ReturnUnitID(unitName)))
            {
                MessageBox.Show("Produkti u shtua!");
            }
            else MessageBox.Show("Produkti nuk u shtua!");
        }

        private void ProductPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ProductCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void unitBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
