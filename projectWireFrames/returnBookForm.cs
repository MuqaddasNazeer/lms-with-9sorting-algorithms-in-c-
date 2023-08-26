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
    public partial class returnBookForm : Form
    {
        private string issuebookPath = "IssueBook.txt";
        public returnBookForm()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            bookGV.DataSource = null;
            bookGV.DataSource = studentIssueBookDL.IssueBooksList;
            bookGV.Refresh();
        }
        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookGV.Refresh();
            studentIssueBook student = (studentIssueBook)bookGV.CurrentRow.DataBoundItem;
            if (bookGV.Columns["Return"].Index == e.ColumnIndex)
            {
                bookGV.Refresh();

                studentIssueBookDL.deleteIssueBookRecFromList(student);
                studentIssueBookDL.storeIssueBookRecDataIntoFile(issuebookPath);
                dataBind();
            }
            
        }
        

       

        private void returnBookForm_Load(object sender, EventArgs e)
        {
            bookGV.DataSource = studentIssueBookDL.IssueBooksList;
            bookGV.Refresh();
        }

        private void bookGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StudentMenu s = new StudentMenu();
            s.Show();
        }
    }
}
