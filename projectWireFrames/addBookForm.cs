using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectWireFrames.DL;
using projectWireFrames.BL;
namespace projectWireFrames
{
    public partial class addBookForm : Form
    {
        
        public addBookForm()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bookNametxt.Text == "")
            {
                label9.Show();
            }
            else
            {
                label9.Visible = false;

            }

            if (AuthorNameTxt.Text == "")
            {
               label11.Visible = true;

            }
            else
            {
                label11.Visible = false;

            }


            if (bookIdTxt.Text == "")
            {
                label10.Visible = true;

            }
            else
            {
                label10.Visible = false;

            }
            if (bookPriceTxt.Text == "")
            {
                label12.Visible = true;

            }
            else
            {
                label12.Visible = false;

            }
            if (bookQuantityTxt.Text == "")
            {
                label13.Visible = true;

            }
            else
            {
                label13.Visible = false;

            }
            if(bookNametxt.Text == ""  || AuthorNameTxt.Text == "" || bookIdTxt.Text == "" || bookPriceTxt.Text == "" || bookQuantityTxt.Text == "")
            {

                MessageBox.Show("Please Fill All Fields And Try Again...");

            }
            else
            {
                string bookName = bookNametxt.Text;
                string authorName = AuthorNameTxt.Text;
                string ID = bookIdTxt.Text;
                string purchseDate = purchaseDateTxt.Text;
                string price = bookPriceTxt.Text;
                string quantity = bookQuantityTxt.Text;
                string path = "bookPath.txt";
                addBook  book = new addBook(bookName, authorName, ID, purchseDate, price, quantity);
                addBookDL.addBookRecordIntoList(book);
                addBookDL.storeAddBookIntoFile(book, path);
                this.Visible = false;
                lms mainForm = new lms();
                mainForm.Show();
                MessageBox.Show("Record Added Successfully...");
                this.Visible = false;
                manageBooks books = new manageBooks();
                books.Show();

            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bookNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookNametxt_Enter(object sender, EventArgs e)
        {
        }

        private void bookNametxt_Leave(object sender, EventArgs e)
        {

            
        }
    }
}
