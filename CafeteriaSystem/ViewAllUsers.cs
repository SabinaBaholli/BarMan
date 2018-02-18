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
using System.Collections;

namespace CafeteriaSystem
{
    public partial class ViewAllUsers : Form
    {
        public ViewAllUsers()
        {
            InitializeComponent();
        }


        private void ViewAllUsers_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (User user in _DataAccess.retreiveKamarieret())
            {
                int userId = user.Id;
               

                usersGridView1.Rows.Add(user.Id, user.Name);

            }
        }

    

        private void usersGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            {
                {
                    if (e.RowIndex >= 0)
                    {
                        if (usersGridView1.Columns[e.ColumnIndex].Name == "EditUser")
                        {
                            int UserId = Convert.ToInt32(usersGridView1.Rows[e.RowIndex].Cells["UserId"].Value);

                            string UserName = usersGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();

                            ArrayList usersTables = new ArrayList();
                            usersTables = _DataAccess.retreiveTables(UserId);

                            UpdateUser UpdateTableForm = new UpdateUser(UserId, UserName, usersTables);

                            if (UpdateTableForm.ShowDialog() == DialogResult.OK)
                            {

                               // Details UpdatedUnitDetail = _DataAccess.RetreiveUnitDetails(UnitID);

                               // usersGridView1.Rows[e.RowIndex].Cells["UnitNameColumn"].Value = UpdatedUnitDetail.Name;


                            }
                        }

                    }
                }
            }
        }
    }
}
