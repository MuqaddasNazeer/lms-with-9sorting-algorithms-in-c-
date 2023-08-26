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
    public partial class deletebookForm : Form
    {
        private string bookPath = "bookPath.txt";
        public deletebookForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void dataBind()
        {
            bookGV.DataSource = null;
            bookGV.DataSource = addBookDL.BooksList;
            bookGV.Refresh();
        }
        
        private void deletebookForm_Load(object sender, EventArgs e)
        {

            bookGV.DataSource = addBookDL.BooksList;
            bookGV.Refresh();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
           
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bookGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageBooks books = new manageBooks();
            this.Visible = false;
            books.Show();
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookGV.Refresh();
            addBook book = (addBook)bookGV.CurrentRow.DataBoundItem;
            if (bookGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                bookGV.Refresh();

                addBookDL.deleteBookFromList(book);
                addBookDL.storeAllBookDataIntoFile(bookPath);
                dataBind();
            }
            else if (bookGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                editBookForm form = new editBookForm(book);
                form.ShowDialog();
                addBookDL.storeAllBookDataIntoFile(bookPath);
                dataBind();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            manageBooks books = new manageBooks();
            this.Visible = false;
            books.Show();
        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
   
    

}
