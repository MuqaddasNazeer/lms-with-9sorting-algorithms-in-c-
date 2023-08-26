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
namespace projectWireFrames
{
    public partial class searchedBookData : Form
    {
        private addBook previous;
       
        public searchedBookData(addBook previous)
        {
            InitializeComponent();
            this.previous = previous;
        }
      
        private void label4_Click(object sender, EventArgs e)
        {

        }
      




       /* private void editBookForm_Load(object sender, EventArgs e)
        {
            bookNametxt.Text = previous.BookName;
            AuthorNameTxt.Text = previous.AuthorName;
            bookIdTxt.Text= previous.Id;
            purchaseDateTxt.Text = previous.PurchaseDate;
            bookPriceTxt.Text = previous.Price;
            bookQuantityTxt.Text = previous.Quantity;
        }*/
        private void button4_Click(object sender, EventArgs e)
        {
            StudentMenu st = new StudentMenu();
            this.Visible = false;
            st.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void issueNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchedBookData_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            StudentMenu s = new StudentMenu();
            this.Visible = false;
            s.Show();
        }

        private void bookNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
