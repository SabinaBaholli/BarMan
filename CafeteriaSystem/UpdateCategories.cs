using System;
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
    public partial class UpdateCategories : Form
    {
        int CategoryID;
        string CategoryName;
        DataGridView categoriesGridView;

        public UpdateCategories(int GivenCategoryID, string GivenCategoryName, DataGridView categoriesGridView1)
        {
            InitializeComponent();
            CategoryID = GivenCategoryID;
            CategoryName = GivenCategoryName;
            categoryIdBox.Text = CategoryID.ToString();
            categoriesGridView = categoriesGridView1;
        }

        private void UpdateCategoriesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("A jeni i sigurte qe doni ta ndryshoni kete kategori?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();

                int CategoryID = Convert.ToInt32(categoryIdBox.Text);

                string categoryName = categoryNameBox.Text;

                if (_DataAccess.UpdateCategory(CategoryID, categoryName))
                {
                    this.Close();

                    //refresh with new data
                    categoriesGridView.Rows.Clear();
                    foreach (Category CategoryDetail in _DataAccess.RetreiveAllCategoriesFromDatabase())
                    {
                         categoriesGridView.Rows.Add(CategoryDetail.ID, CategoryDetail.Name);
                    }
                }
                else MessageBox.Show("Kategoria nuk u ndryshua", "Error", MessageBoxButtons.OK);
            }
        }

        private void UpdateSuppliers_Load(object sender, EventArgs e)
        {
          
       
        }
    }
}
