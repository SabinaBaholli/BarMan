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
    public partial class ViewAllTables : Form
    {
        public ViewAllTables()
        {
            InitializeComponent();
        }

        private void ViewAllTables_Load_1(object sender, EventArgs e)
                {
                    DataAccess _DataAccess = new DataAccess();

                    foreach (Table TableDetail in _DataAccess.RetreiveAllTables())
                    {
                        TablesGridView.Rows.Add(TableDetail.Id, TableDetail.Name, TableDetail.Owner);
                    }
                }

        private void TablesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    if (TablesGridView.Columns[e.ColumnIndex].Name == "DeleteTableColumn")
                    {
                        if (MessageBox.Show("A jeni i sigurtë për fshirjen e tavolines nga databaza?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int TableID = Convert.ToInt32(TablesGridView.Rows[e.RowIndex].Cells["TableIDColumn"].Value);

                            DataAccess _DataAccess = new DataAccess();

                            if (_DataAccess.DeleteTable(TableID))
                            {
                                TablesGridView.Rows.RemoveAt(e.RowIndex);
                            }
                            else if (!_DataAccess.DeleteTable(TableID))
                            {
                                MessageBox.Show("Tabela nuk u fshi");
                            }
                        }
                    }
                    else if (TablesGridView.Columns[e.ColumnIndex].Name == "EditTableColumn")
                    {
                        int TableID = Convert.ToInt32(TablesGridView.Rows[e.RowIndex].Cells["TableIDColumn"].Value);

                        string TableName = TablesGridView.Rows[e.RowIndex].Cells["TableNameColumn"].Value.ToString();

                        UpdateTables UpdateTableForm = new UpdateTables(TableID, TableName, TablesGridView);

                        if (UpdateTableForm.ShowDialog() == DialogResult.OK)
                        {
                            DataAccess _DataAccess = new DataAccess();

                            Details UpdatedTableDetail = _DataAccess.RetreiveTableDetails(TableID);

                            TablesGridView.Rows[e.RowIndex].Cells["TableNameColumn"].Value = UpdatedTableDetail.Name;


                        }
                    }
                }
            }



        }

        
    }
}
