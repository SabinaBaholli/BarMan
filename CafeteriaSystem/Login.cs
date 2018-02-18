using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
          
            string UserEmail = EmailBox.Text;

            if (ConfirmEmailAddress(UserEmail))
            {
                string UserPassword = PasswordBox.Text;

                if (ConfirmPassword(UserPassword))
                {
                    DataAccess _DataAccess = new DataAccess();

                    if (_DataAccess.ConfirmUser(UserEmail, UserPassword))
                    {
                        int UserID = Convert.ToInt32(_DataAccess.ReturnUserID(UserEmail));
                        int RoleID = Convert.ToInt32(_DataAccess.ReturnUserRole(UserEmail));
                        
                        ApplicationState State = _DataAccess.GetState();

                        if(RoleID == 1)
                        {
                            AdminDashboard _Dashboard = new AdminDashboard(UserID, State);
                            _Dashboard.Show();
                            this.Hide();
                        } else if (RoleID == 2)
                        {
                            WaiterDashboard _Dashboard = new WaiterDashboard(UserID, State);
                            _Dashboard.Show();
                            this.Hide();
                        } else
                        {
                            MessageBox.Show("Nuk keni privilegje per te hyre ne sistem.");
                        }
                    }
                    else MessageBox.Show("Kredenciale te pasakta. Ju lutem, provoni perseri!");
                }
                else MessageBox.Show("Ju lutem, shkruani fjalekalimin e sakte!");
            }
            else MessageBox.Show("Ju lutem, shkruani email-in e sakte!");
        }

        public bool ConfirmEmailAddress(string UserEmail)
        {
            var EmailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return EmailRegex.IsMatch(UserEmail);
        }

        public bool ConfirmPassword(string UserPassword)
        {
            UserPassword = UserPassword.Trim();

            if (UserPassword == string.Empty)
            {
                return false;
            }
            else return true;
        }


        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
