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
using projectWireFrames;
namespace projectWireFrames
{
    public partial class editBookForm : Form
    {
        private addBook previous;
        public editBookForm(addBook previous)
        {
            InitializeComponent();
            this.previous = previous;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            addBook updated = new addBook(bookNametxt.Text, AuthorNameTxt.Text, int.Parse(bookIdTxt.Text), bookPriceTxt.Text, bookQuantityTxt.Text);
            addBookDL.EditBookFromList(previous, updated);
            this.Close();
        }
 
        private void editBookForm_Load(object sender, EventArgs e)
        {
            bookNametxt.Text = previous.BookName;
            AuthorNameTxt.Text = previous.AuthorName;
            bookIdTxt.Text = (previous.Id).ToString();
            bookPriceTxt.Text = previous.Price;
            bookQuantityTxt.Text = previous.Quantity;
        }

        private void editBookForm_Load_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
