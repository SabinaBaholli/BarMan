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
    public partial class ViewAllUnits : Form
    {
        public ViewAllUnits()
        {
            InitializeComponent();
        }

        private void ViewAllUnits_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Unit UnitDetail in _DataAccess.RetreiveAllUnitsFromDatabase())
            {
                unitGridView1.Rows.Add(UnitDetail.ID, UnitDetail.Name);
            }
        }

        private void unitGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                {
                    if (e.RowIndex >= 0)
                    {
                        if (unitGridView1.Columns[e.ColumnIndex].Name == "DeleteUnitColumn")
                        {
                            if (MessageBox.Show("A jeni i sigurtë për fshirjen e njesise nga databaza?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                int UnitID = Convert.ToInt32(unitGridView1.Rows[e.RowIndex].Cells["UnitIdColumn"].Value);

                                DataAccess _DataAccess = new DataAccess();

                                if (_DataAccess.DeleteUnit(UnitID))
                                {
                                    unitGridView1.Rows.RemoveAt(e.RowIndex);
                                }
                                else if (!_DataAccess.DeleteUnit(UnitID))
                                {
                                    MessageBox.Show("Njesia nuk u fshi");
                                }
                            }
                        }
                        else if (unitGridView1.Columns[e.ColumnIndex].Name == "EditUnitColumn")
                        {
                            int UnitID = Convert.ToInt32(unitGridView1.Rows[e.RowIndex].Cells["UnitIdColumn"].Value);

                            string UnitName = unitGridView1.Rows[e.RowIndex].Cells["UnitNameColumn"].Value.ToString();

                            UpdateUnits UpdateTableForm = new UpdateUnits(UnitID, UnitName, unitGridView1);

                            if (UpdateTableForm.ShowDialog() == DialogResult.OK)
                            {
                                DataAccess _DataAccess = new DataAccess();

                                Details UpdatedUnitDetail = _DataAccess.RetreiveUnitDetails(UnitID);

                                unitGridView1.Rows[e.RowIndex].Cells["UnitNameColumn"].Value = UpdatedUnitDetail.Name;


                            }
                        }

                    }
                }
            }
        }
    }
}
