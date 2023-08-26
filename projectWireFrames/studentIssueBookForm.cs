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
    public partial class studentIssueBookForm : Form
    {

        public studentIssueBookForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(issueNametxt.Text == "")
            {
                label11.Visible = true;
            }
            else
                label11.Visible = false;

            if(nameTxt.Text == "")
            {
                label9.Visible = true;
            }
            else
                label9.Visible = false;

            if(departmentTxt.Text == "")
            {
                label8.Visible = true;
            }
            else
                label8.Visible = false;

            if (contactTxt.Text == "")
            {
                label7.Visible = true;
            }
            else
                label7.Visible = false;
            if(issueNametxt.Text == "" || nameTxt.Text == "" || departmentTxt.Text == "" || contactTxt.Text == "")

            {
                MessageBox.Show("Please Fill All Fields And try Again..");
            }
            else
            {
                bool flag = false;
                string bookName = issueNametxt.Text;
                string name = nameTxt.Text;
                string date = DateTxt.Text;
                string department = departmentTxt.Text;
                string contact = contactTxt.Text;
                string path = "IssueBook.txt";
                foreach (addBook book in addBookDL.BooksList)
                {
                    if (book.BookName == issueNametxt.Text)
                    {
                                    
                        flag = true;
                        studentIssueBook issueBook = new studentIssueBook(bookName, name, date, department, contact);
                        studentIssueBookDL.addStuIssueBooktoList(issueBook);
                        studentIssueBookDL.storeStuIssueBookIntoFile(issueBook, path);
                        MessageBox.Show("Record Added Successfully...");
                        this.Visible = false;
                        StudentMenu student = new StudentMenu();
                        student.Show();
                        break;
                    }
                    
                }
                
                if(flag == false)
                {
                    issueNametxt.Text = "";
                    nameTxt.Text = "";
                    DateTxt.Text = "";
                    departmentTxt.Text = "";
                    contactTxt.Text = "";
                    MessageBox.Show("This Book is Currently Not Avaliable...");

                }

            }
        }

        private void issueNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void studentIssueBookForm_Enter(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentMenu student = new StudentMenu();
            this.Visible = false;
            student.Show();
        }

        private void studentIssueBookForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
