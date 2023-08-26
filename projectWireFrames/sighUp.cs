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
    public partial class sighUp : Form
    {
        public sighUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(userNametxt.Text  == "")
            {
                userNametxt.Text = "UserName";
            }
            userNametxt.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (userNametxt.Text == "")
            {
                userNametxt.Text = "UserName";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(passwordtxt.Text == "")
            {
                passwordtxt.Text = "Password";
            }
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                passwordtxt.Text = "Password";
            }
            passwordtxt.Text = "";

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (roletxt.Text == "")
            {
                roletxt.Text = "Role";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (roletxt.Text == "")
            {
                roletxt.Text = "Role";
            }
            roletxt.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lms l = new lms();
            l.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = userNametxt.Text;
            string password = passwordtxt.Text;
            string role = roletxt.Text;
            string path = "data.txt";
            User user = new User(userName, password, role);
            UserDL.addUserIntoList(user);
            UserDL.storeUserIntoFile(user, path);
            MessageBox.Show("User Added!");

            this.Visible = false;
            lms mainForm = new lms();
            mainForm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sighUp_Load(object sender, EventArgs e)
        {

        }
    }
}
