using projectWireFrames.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectWireFrames
{
    public partial class sortingMenu : Form
    {
        public sortingMenu()
        {
            InitializeComponent();
        }

       

        

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void bbl_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.bubbleSort(addBookDL.BooksList);
            string path = "bbl_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
        }

        private void selection_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.selectionSort(addBookDL.BooksList);
            string path = "selection_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
        }

        private void insertion_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.insertionSort(addBookDL.BooksList);
            string path = "insertion_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
        }

        private void merge_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.mergeSort(addBookDL.BooksList,0, addBookDL.BooksList.Count-1);
            string path = "merge_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void View_data_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
        }

        private void heap_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.heapSort(addBookDL.BooksList,  addBookDL.BooksList.Count );
            string path = "heap_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();

        }

        private void quick_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.quickSort(addBookDL.BooksList,0, addBookDL.BooksList.Count-1);
            string path = "quick_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
        }

        private void counting_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.countingSort(addBookDL.BooksList);
            string path = "counting_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
        }

        private void redix_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.radixSort(addBookDL.BooksList);
            string path = "radix_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
        }

        private void bucket_sort_Click(object sender, EventArgs e)
        {
            addBookDL.SortedbooksList1 = addBookDL.bucketSort(addBookDL.BooksList);
            string path = "bucket_sorting.txt";
            addBookDL.sortAllBookDataIntoFile(path);
            this.Visible = false;
            viewAllBookForm viewBooks = new viewAllBookForm();
            viewBooks.Show();
        }
    }
}
        