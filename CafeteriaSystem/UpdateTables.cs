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
    public partial class UpdateTables : Form
    {
        int TableID;
        string TableName;
        DataGridView TablesGridView1;

        public UpdateTables(int GivenTableID, string GivenTableName, DataGridView TablesGridView)
        {
            InitializeComponent();
            TableID = GivenTableID;
            TableName = GivenTableName;
            tableIdBox.Text = TableID.ToString();
            TablesGridView1 = TablesGridView;

        }

        private void tableIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTableButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("A jeni i sigurte qe doni ta ndryshoni kete tavoline?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();

                int TableID = Convert.ToInt32(tableIdBox.Text);

                string TableName = tableNameBox.Text;

                if (_DataAccess.UpdateTable(TableID, TableName))
                {
                    this.Close();
                    TablesGridView1.Rows.Clear();
                    foreach (Table TableDetail in _DataAccess.RetreiveAllTables())
                    {
                        TablesGridView1.Rows.Add(TableDetail.Id, TableDetail.Name);
                    }
                }
                else MessageBox.Show("Tavolina nuk u ndryshua", "Error", MessageBoxButtons.OK);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTables_Load(object sender, EventArgs e)
        {

        }
    }
}
