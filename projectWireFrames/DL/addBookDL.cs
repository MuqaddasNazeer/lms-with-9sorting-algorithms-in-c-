using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using projectWireFrames.BL;
namespace projectWireFrames.DL
{
    class addBookDL
    {
        private static List<addBook> booksList = new List<addBook>();

        internal static List<addBook> BooksList { get => booksList; set => booksList = value; }

        public static void addBookRecordIntoList(addBook book)
        {
            booksList.Add(book);
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == '/')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool readAddBookDataFromFile(string bookPath)
        {
            if (File.Exists(bookPath))
            {
                StreamReader fileVariable = new StreamReader(bookPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string bookName = parseData(record, 1);
                    string authorName= parseData(record, 2);
                    string id = parseData(record, 3);
                    string purchaseDate = parseData(record, 4);
                    string price = parseData(record, 5);
                    string Quantity = parseData(record, 6);
                    addBook book = new addBook(bookName, authorName, id, purchaseDate, price, Quantity);
                    addBookDL.addBookRecordIntoList(book);
                   
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeAddBookIntoFile(addBook book, string bookPath)
        {
            StreamWriter file = new StreamWriter(bookPath, true);
            file.WriteLine(book.BookName+ "/" + book.AuthorName + "/" + book.Id +  "/" + book.PurchaseDate + "/" + book.Price + "/" + book.Quantity);
            file.Flush();
            file.Close();

        }

        
    }
}
