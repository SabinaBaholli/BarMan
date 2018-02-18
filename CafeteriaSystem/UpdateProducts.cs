using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class UpdateProducts : Form
    {
        int ProductID;
        string ProductName, ProductCategory, ProductUnit, ProductQuantity;
        decimal ProductPrice;
   

        public UpdateProducts(int GivenProductID, string GivenProductName, decimal GivenProductPrice, string GivenProductCategory, string GivenProductUnit, string GivenProductQuantity)
        {
            InitializeComponent();

            ProductID = GivenProductID;
            ProductName = GivenProductName;
            ProductPrice = GivenProductPrice;
            ProductCategory = GivenProductCategory;
            ProductUnit = GivenProductUnit;
            ProductQuantity = GivenProductQuantity;
        }

        private void UpdateProucts_Load(object sender, EventArgs e)
        {
            ProductIDBox.Text = ProductID.ToString();
            ProductNameBox.Text = ProductName;
            ProductPriceBox.Text = ProductPrice.ToString();
            ProductCategoryComboBox.Text = ProductCategory;
            unitBox.Text = ProductUnit;
            quantityBox1.Text = ProductQuantity;

            DataAccess _DataAccess = new DataAccess();

            foreach (Category CategoryDetail in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                ProductCategoryComboBox.Items.Add(CategoryDetail.Name);
            }
            foreach (Unit UnitDetails in _DataAccess.RetreiveAllUnitsFromDatabase())
            {
                unitBox.Items.Add(UnitDetails.Name);
            }
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            /*selecting image*/

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                /*if picture selected then load in the picture box*/
          //      ProductPictureBox.Load(ofd.FileName);
            }
        }

        private void ProductPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void unitBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeni te sigurt qe doni ta ndryshoni kete produkt?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();

                int ProductID = Convert.ToInt32(ProductIDBox.Text);

                string ProductName = ProductNameBox.Text;

                decimal ProductPrice = Convert.ToDecimal(ProductPriceBox.Text);

                string ProductCategory = ProductCategoryComboBox.Text;

                int ProductCategoryID = _DataAccess.ReturnCategoryID(ProductCategory);

                string ProductUnit = unitBox.Text;

                int unitId = _DataAccess.ReturnUnitID(ProductUnit);

                int ProductQuantity = Convert.ToInt32(quantityBox1.Text);

                if (_DataAccess.UpdateProduct(ProductID, ProductName, ProductPrice, ProductCategoryID, unitId, ProductQuantity))
                {
                    MessageBox.Show("Produkti u ndryshua!");
                    this.Close();
                }
                else MessageBox.Show("Produkti nuk u ndryshua!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
