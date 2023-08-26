using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWireFrames.BL
{
    class addBook
    {
        private string bookName;
        private string authorName;
        private string id;
        private string purchaseDate;
        private string price;
        private string quantity;

        public addBook(string bookName, string authorName, string id, string purchaseDate, string price, string quantity)
        {
            BookName = bookName;
            AuthorName = authorName;
            Id = id;
            PurchaseDate = purchaseDate;
            Price = price;
            Quantity = quantity;
        }

        public string BookName { get => bookName; set => bookName = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Id { get => id; set => id = value; }
        public string PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public string Price { get => price; set => price = value; }
        public string Quantity { get => quantity; set => quantity = value; }
    }
}
