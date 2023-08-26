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
    public partial class deleteEditStudentForm : Form
    {
        private string studentpath = "StudentPath.txt";
        public deleteEditStudentForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            manageStudents studentView = new manageStudents();
            this.Visible = false;
            studentView.Show();
        }
        public void dataBind()
        {
            bookGV.DataSource = null;
            bookGV.DataSource = addStudentDL.StudentsList;
            bookGV.Refresh();
        }

        private void deletebookForm_Load(object sender, EventArgs e)
        {

            

        }

        private void bookGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookGV.Refresh();
            addStudent student = (addStudent)bookGV.CurrentRow.DataBoundItem;
            if (bookGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                bookGV.Refresh();

                addStudentDL.deleteStudentFromList(student);
                addStudentDL.storeAllStudentDataIntoFile(studentpath);
                dataBind();
            }
            else if (bookGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                editStudent form = new editStudent(student);
                form.ShowDialog();
                addStudentDL.storeAllStudentDataIntoFile(studentpath);
                dataBind();
            }
        }
        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookGV.Refresh();
            addStudent student = (addStudent)bookGV.CurrentRow.DataBoundItem;
            if (bookGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                bookGV.Refresh();

                addStudentDL.deleteStudentFromList(student);
                addStudentDL.storeAllStudentDataIntoFile(studentpath);
                dataBind();
            }
            else if (bookGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                editStudent form = new editStudent(student);
                form.ShowDialog();
                addStudentDL.storeAllStudentDataIntoFile(studentpath);
                dataBind();
            }
        }

        private void deleteEditStudentForm_Load(object sender, EventArgs e)
        {
            bookGV.DataSource = addStudentDL.StudentsList;
            bookGV.Refresh();
        }
    }
}
