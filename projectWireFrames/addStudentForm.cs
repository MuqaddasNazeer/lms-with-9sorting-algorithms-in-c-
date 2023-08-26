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
    public partial class addStudentForm : Form
    {
        public addStudentForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bookPriceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(StudentNametxt.Text == "")
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;

            }
            if(IdTxt.Text == "")
            {
                label12.Visible = true;
            }
            else
            {
                label12.Visible = false;

            }
            if(issuedBkTxt.Text == "")
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
            if(returnedBkTxt.Text == "")
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
            if(semesterTxt.Text == "")
            {
                label14.Visible = true;

            }
            else
            {
                label14.Visible = false;
            }
            if(degreeTxt.Text == "")
            {
                label8.Visible = true;

            }
            else
            {
                label8.Visible = false;

            }
            if (StudentNametxt.Text == "" || IdTxt.Text == "" || issuedBkTxt.Text == "" || returnedBkTxt.Text  == "" || semesterTxt.Text == "" || degreeTxt.Text == "")
            {

                MessageBox.Show("Please Fill All Fields And Try Again...");

            }
            else
            {
                string studentName = StudentNametxt.Text;
                string id = IdTxt.Text;
                string issuedBooks = issuedBkTxt.Text;
                string returnedBooks = returnedBkTxt.Text;
                string currentSemester = semesterTxt.Text;
                string degree= degreeTxt.Text;
                string path = "StudentPath.txt";
                addStudent student = new addStudent(studentName, id, issuedBooks, returnedBooks, degree, currentSemester);
                addStudentDL.addStudentRecordIntoList(student);
                addStudentDL.storeStudentIntoFile(student, path);
                this.Visible = false;
                MessageBox.Show("Record Added Successfully...");
                manageStudents students = new manageStudents();
                students.Show();

            }
        }

        private void addStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
