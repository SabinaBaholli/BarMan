using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeteriaSystem.models;

namespace CafeteriaSystem
{
    public partial class ViewAllSuppliers : Form
    {
        public ViewAllSuppliers()
        {
            InitializeComponent();
        }
            private void ViewAllSuppliers_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Supplier SupplierDetail in _DataAccess.RetreiveAllSuppliersFromDatabase())
            {
                supplierGridView1.Rows.Add(SupplierDetail.ID, SupplierDetail.Name, SupplierDetail.PhoneNumber);
            }
        }

        private void supplierGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    if (supplierGridView1.Columns[e.ColumnIndex].Name == "DeleteSupplier")
                    {
                        if (MessageBox.Show("A jeni i sigurtë për fshirjen e furnitorit nga databaza?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int SupplierID = Convert.ToInt32(supplierGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value);

                            DataAccess _DataAccess = new DataAccess();

                            if (_DataAccess.DeleteSupplier(SupplierID))
                            {
                                supplierGridView1.Rows.RemoveAt(e.RowIndex);
                            }
                            else if (!_DataAccess.DeleteSupplier(SupplierID))
                            {
                                MessageBox.Show("Furnitori nuk u fshi");
                            }
                        }
                    }
                    else if (supplierGridView1.Columns[e.ColumnIndex].Name == "EditSupplier")
                    {
                        int SupplierID = Convert.ToInt32(supplierGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value);

                        string SupplierName = supplierGridView1.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();

                        string SupplierPhone = supplierGridView1.Rows[e.RowIndex].Cells["SupplierPhone"].Value.ToString();

                        UpdateSuppliers UpdateTableForm = new UpdateSuppliers(SupplierID, SupplierName, SupplierPhone, supplierGridView1);

                        if (UpdateTableForm.ShowDialog() == DialogResult.OK)
                        {
                            DataAccess _DataAccess = new DataAccess();

                            Details UpdatedTableDetail = _DataAccess.RetreiveTableDetails(SupplierID);

                            supplierGridView1.Rows[e.RowIndex].Cells["SupplierName"].Value = UpdatedTableDetail.Name;


                        }
                    }

                }
            }
        }


      
    }
}
