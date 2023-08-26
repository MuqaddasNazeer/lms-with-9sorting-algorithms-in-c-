using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectWireFrames.BL;
using projectWireFrames.DL;
namespace projectWireFrames
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void userNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNametxt_Enter(object sender, EventArgs e)
        {
            if (userNametxt.Text == "")
            {
                userNametxt.Text = "UserName";
            }
            userNametxt.Text = "";
        }

        private void userNametxt_Leave(object sender, EventArgs e)
        {
            if (userNametxt.Text == "")
            {
                userNametxt.Text = "UserName";
            }
        }

        private void passwordtxt_Enter(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                passwordtxt.Text = "Password";
            }
            passwordtxt.Text = "";
        }

        private void passwordtxt_Leave(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                passwordtxt.Text = "Password";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lms fm = new lms();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = userNametxt.Text;
            string password = passwordtxt.Text;
            User user = new User(userName, password);
            User validUser = UserDL.SignIn(user);
            if (validUser != null)
            {
                if (validUser.isAdmin() == true)
                {
                    librarianMenu lib = new librarianMenu();
                    this.Visible = false;
                    lib.Show();

                }
                else if(validUser.UserRole == "Student" || validUser.UserRole == "student")
                {
                    this.Visible = false;
                    StudentMenu student = new StudentMenu();
                    student.Show();

                }
                else if(validUser.isAdmin() == false || (validUser.UserRole != "Student" || validUser.UserRole != "student"))
                {
                   // MessageBox.Show("Invalid User! Please Try Again..");
                    lms mainForm = new lms();
                    mainForm.Show();
                }
            }
        }
    }
}
