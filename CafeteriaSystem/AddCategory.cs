using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
        }

   
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            bool CategoryAddedOrNot = _DataAccess.AddNewCategoryToDatabase(CategoryNameBox.Text);

            if (CategoryAddedOrNot)
            {
                MessageBox.Show("Kategoria u shtua");
            }
            else MessageBox.Show("Kategoria nuk u Shtua");
        }



        private void CategoryNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
