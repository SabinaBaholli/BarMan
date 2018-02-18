using System;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string UserName = NameBox.Text;
            string UserEmail = EmailBox.Text;
            string UserPassword = PasswordBox.Text;
            string role = RoleBox.Text;
            int UserRole; 
            if( role == "Menaxher"){
                UserRole = 1;
            }
            else
            {
                UserRole = 2;
            }

            //we have to register a user
            DataAccess _DataAccess = new DataAccess();

            if (_DataAccess.RegisterUser(UserName, UserEmail, UserPassword, UserRole))
            {
                int UserID = Convert.ToInt32(_DataAccess.ReturnUserID(UserEmail));

                AdminDashboard _Dashboard = new AdminDashboard(UserID, _DataAccess.GetState());
                MessageBox.Show("Perdoruesi u regjistrua me sukses ne rolin " + role);

                this.Hide();

                _Dashboard.Show();
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
