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
    public partial class UpdateUnits : Form
    {
        int unitID;
        string UnitName;
        DataGridView unitGridView;

        public UpdateUnits(int GivenUnitID, string GivenUnitName, DataGridView unitGridView1)
        {
            InitializeComponent();
            unitID = GivenUnitID;
            UnitName = GivenUnitName;
            unitIdBox.Text = unitID.ToString();
            unitGridView = unitGridView1;
        }

        private void UpdateUnits_Load(object sender, EventArgs e)
        {


        }

        private void UpdateUnitsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("A jeni i sigurte qe doni ta ndryshoni kete njesi?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();

                int UnitID = Convert.ToInt32(unitIdBox.Text);

                string unitName = unitNameBox.Text;

                if (_DataAccess.UpdateUnit(UnitID, unitName))
                {
                    this.Close();

                    //refresh with new data
                    unitGridView.Rows.Clear();
                    foreach (Unit UnitDetail in _DataAccess.RetreiveAllUnitsFromDatabase())
                    {
                        unitGridView.Rows.Add(UnitDetail.ID, UnitDetail.Name);
                    }
                }
                else MessageBox.Show("Njesia nuk u ndryshua", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
