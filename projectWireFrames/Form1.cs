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
    public partial class lms : Form
    {
        string path = "data.txt";
        public lms()
        {
            InitializeComponent();
           /* string path = "data.txt";
            if(UserDL.readDataFromFile(path))
            {
                MessageBox.Show("Data Loaded From File");
            }
            else
            {
                MessageBox.Show("Data Not Loaded");
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserDL.readDataFromFile(path);

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            signIn libLogin = new signIn();
            libLogin.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            sighUp libLogin = new sighUp();
            libLogin.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
