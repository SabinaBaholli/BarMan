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
    public partial class UpdateSuppliers : Form
    {

        int SupplierId;
        DataGridView supplierGridView;


        public UpdateSuppliers(int Id, string Name,string PhoneNr, DataGridView supplierGrid)
        {
            InitializeComponent();
            SupplierId = Id;
            supplierGridView = supplierGrid;

        }

        public void supplierUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("A jeni i sigurte qe doni ta ndryshoni kete furnitor?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();


                string SupplierName = supplierNameBox1.Text;
                string phoneNr = supplierPhoneBox1.Text;    


                if (_DataAccess.UpdateSuppliers(SupplierId, SupplierName, phoneNr))
                {
                    this.Close();

                    //refresh with new data
                    supplierGridView.Rows.Clear();
                    foreach (Supplier SupplierDetail in _DataAccess.RetreiveAllSuppliersFromDatabase())
                    {
                        supplierGridView.Rows.Add(SupplierId, SupplierDetail.Name, SupplierDetail.PhoneNumber);
                    }
                }
                else MessageBox.Show("Kategoria nuk u ndryshua", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
