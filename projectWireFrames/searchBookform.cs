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
    public partial class searchBookform : Form
    {

        public searchBookform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(addBook book in addBookDL.BooksList)
            {
                if(issueNametxt.Text == book.BookName)
                {
                    searchedBookData bookData = new searchedBookData(book);
                    this.Visible = false;
                    bookData.Visible = true;
                    flag = true;

                    break;

                }
            }
            if(flag == false)
            {
                MessageBox.Show("Record Not Exists..");
                this.Visible = false;
                StudentMenu student = new StudentMenu();
                student.Visible = true;
            }

        }

        private void issueNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBookform_Load(object sender, EventArgs e)
        {

        }
    }
}
