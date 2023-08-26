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
    public partial class viewStudentsForm : Form
    {
        public viewStudentsForm()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = addStudentDL.StudentsList;
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewStudentsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = addStudentDL.StudentsList; // introspection

        }

        private void button4_Click(object sender, EventArgs e)
        {
            manageStudents student = new manageStudents();
            this.Visible = false;
            student.Show();
        }
    }
}
