using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectWireFrames
{
    public partial class librarianMenu : Form
    {
        public librarianMenu()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manageBooks books = new manageBooks();
            books.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lms mainForm = new lms();
            mainForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manageStudents students = new manageStudents();
            students.Show();
        }
    }
}
