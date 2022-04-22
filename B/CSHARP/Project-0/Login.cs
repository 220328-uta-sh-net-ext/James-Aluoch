using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserId = "James";
            string password = "J@aluoch";
            if (txtUserID.Text.Equals(UserId) && txtPwd.Text.Equals(password))
            {
                Login ln = new Login();
                ln.Show();
                MessageBox.Show("You have logged in successfully", "Message");
            }
            else
                MessageBox.Show("Login unsuccessful, please try again", "Message");
        }
    }
}
