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
    public partial class AddTable : Form
    {
        public AddTable()
        {
            InitializeComponent();
        }

        private void AddTableButton_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TableNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTableButton_Click_1(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();
            int selectedValue = Convert.ToInt32(kamarierComboBox1.SelectedItem);
            bool TableAddedOrNot = _DataAccess.AddNewTableToDatabase(TableNameBox.Text, selectedValue);

            if (TableAddedOrNot)
            {
                MessageBox.Show("Tabela u shtua");
            }
            else MessageBox.Show("Tabela nuk u shtua");
        }

        private void AddTable_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();
           foreach(User kam in _DataAccess.retreiveKamarieret())
            {
                kamarierComboBox1.Items.Add(kam.Id);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
