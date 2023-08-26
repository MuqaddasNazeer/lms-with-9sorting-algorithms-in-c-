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
    
    public partial class editStudent : Form
    {
        private addStudent previous;

        public editStudent(addStudent previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void editStudent_Load(object sender, EventArgs e)
        {
            StudentNametxt.Text = previous.StudentName;
            IdTxt.Text = previous.StudentId;
            issuedBkTxt.Text = previous.IssuedBooks;

            returnedBkTxt.Text = previous.ReturnedBooks;
            degreeTxt.Text = previous.Degree;
            semesterTxt.Text = previous.Semester;
        }
        




       

        private void button1_Click_1(object sender, EventArgs e)
        {
            addStudent updated = new addStudent(StudentNametxt.Text, IdTxt.Text, issuedBkTxt.Text, returnedBkTxt.Text, degreeTxt.Text, semesterTxt.Text);
            addStudentDL.EditStudentFromList(previous, updated);
            this.Close();
        }

        private void StudentNametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
