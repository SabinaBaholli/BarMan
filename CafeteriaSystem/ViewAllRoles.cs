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
    public partial class ViewAllRoles : Form
    {
        public ViewAllRoles()
        {
            InitializeComponent();
        }

        private void ViewAllRoles_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Role RoleDetail in _DataAccess.RetreiveAllRoles())
            {
                dataGridView1.Rows.Add(RoleDetail.ID, RoleDetail.Name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
