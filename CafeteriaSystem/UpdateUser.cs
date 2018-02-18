using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CafeteriaSystem
{
    public partial class UpdateUser : Form
    {
        string userName;
        int userId;

        public UpdateUser(int UserId, string UserName, ArrayList usersTables)
        {
            userId = UserId;
            userName = UserName;
            ArrayList usertab = usersTables;

            InitializeComponent();
            userNameBox.Text = userName;
            foreach (Table table in usersTables) { 
                rolesTablesGridView1.Rows.Add(table.Name, table.Id);
            }
        }

        private void updateWaiterUser_Click(object sender, EventArgs e)
        {
           //_DA.UpdateUser(string userNameBox.Text, int)
        }

        private void userTablesGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int tableId = Convert.ToInt32(rolesTablesGridView1.Rows[e.RowIndex].Cells["TableId"].Value);

            {
                if (e.RowIndex >= 0)
                {
                    if (rolesTablesGridView1.Columns[e.ColumnIndex].Name == "deleteRole")
                    {
                        if (MessageBox.Show("A jeni i sigurtë për fshirjen e rolit per ju?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            DataAccess _DataAccess = new DataAccess();

                            if (_DataAccess.DeleteRole(tableId))
                            {
                                rolesTablesGridView1.Rows.RemoveAt(e.RowIndex);
                            }
                            else if (!_DataAccess.DeleteRole(tableId))
                            {
                                MessageBox.Show("Tabela nuk u fshi");
                            }
                        }
                    }
                    else if (rolesTablesGridView1.Columns[e.ColumnIndex].Name == "EditRole")
                    {
                        DataAccess _DataAccess = new DataAccess();
                         int newOwner = Convert.ToInt32(rolesTablesGridView1.Rows[e.RowIndex].Cells["newOwner"].Value);

                        if (_DataAccess.EditRole(tableId, newOwner))
                        {
                            rolesTablesGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                        else if (!_DataAccess.EditRole(tableId, newOwner))
                        {
                            MessageBox.Show("Tabela nuk u fshi");
                        }
                    }
                }
            }
                   
              
                }
    }
}
