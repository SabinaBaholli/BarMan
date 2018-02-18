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
    public partial class AddUnit : Form
    {
        public AddUnit()
        {
            InitializeComponent();
        }

        private void AddUnit_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            bool UnitAddedOrNot = _DataAccess.AddNewUnitToDatabase(textBox2.Text);

            if (UnitAddedOrNot)
            {
                MessageBox.Show("Njesia u shtua");
                this.Close();
            }
            else MessageBox.Show("Njesia nuk u Shtua");
        }
    }
}
