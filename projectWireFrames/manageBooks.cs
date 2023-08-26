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
namespace projectWireFrames
{
    public partial class manageBooks : Form
    {
        string bookPath = "bookpath.txt";

        public manageBooks()
        {
            InitializeComponent();
             string path = "bookPath.txt";
            if(addBookDL.readAddBookDataFromFile(path))
            {
                MessageBox.Show(" book Data Loaded From File");
            }
            else
            {
                MessageBox.Show("Data Not Loaded");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addBookForm book = new addBookForm();
            this.Visible = false;
            book.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            librarianMenu lbMenu = new librarianMenu();
            lbMenu.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void manageBooks_Load(object sender, EventArgs e)
        {
            addBookDL.readAddBookDataFromFile(bookPath);

        }
    }
}
