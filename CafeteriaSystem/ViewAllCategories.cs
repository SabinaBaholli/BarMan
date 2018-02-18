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
    public partial class ViewAllCategories : Form
    {
        public ViewAllCategories()
        {
            InitializeComponent();
        }

        private void ViewAllCategories_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Category CategoryDetail in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                categoriesGridView1.Rows.Add(CategoryDetail.ID, CategoryDetail.Name);
            }
        }

        private void categoriesGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    if (categoriesGridView1.Columns[e.ColumnIndex].Name == "DeleteCategoryColumn")
                    {
                        if (MessageBox.Show("A jeni i sigurtë për fshirjen e kategorise nga databaza?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int CategoryID = Convert.ToInt32(categoriesGridView1.Rows[e.RowIndex].Cells["CategoryIDColumn"].Value);

                            DataAccess _DataAccess = new DataAccess();

                            if (_DataAccess.DeleteCategory(CategoryID))
                            {
                                categoriesGridView1.Rows.RemoveAt(e.RowIndex);
                            }
                            else if (!_DataAccess.DeleteCategory(CategoryID))
                            {
                                MessageBox.Show("Kategoria nuk u fshi");
                            }
                        }
                    }
                    else if (categoriesGridView1.Columns[e.ColumnIndex].Name == "EditCategoryColumn")
                    {
                        int CategoryID = Convert.ToInt32(categoriesGridView1.Rows[e.RowIndex].Cells["CategoryIdColumn"].Value);

                        string CategoryName = categoriesGridView1.Rows[e.RowIndex].Cells["CategoryNameColumn"].Value.ToString();

                        UpdateCategories UpdateTableForm = new UpdateCategories(CategoryID, CategoryName, categoriesGridView1);

                        if (UpdateTableForm.ShowDialog() == DialogResult.OK)
                        {
                            DataAccess _DataAccess = new DataAccess();

                            Details UpdatedTableDetail = _DataAccess.RetreiveTableDetails(CategoryID);

                            categoriesGridView1.Rows[e.RowIndex].Cells["CategoryNameColumn"].Value = UpdatedTableDetail.Name;


                        }
                    }

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
