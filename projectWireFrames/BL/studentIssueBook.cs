using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectWireFrames.DL;
using System.IO;
namespace projectWireFrames.BL
{
    public class studentIssueBook
    {
        private string issuedBookName;
        private string stuIssueBook;
        private string issueDate;
        private string department;
        private string contacNo;

        public studentIssueBook(string issuedBookName, string stuIssueBook, string issueDate, string department, string contacNo)
        {
            this.IssuedBookName = issuedBookName;
            this.StuIssueBook = stuIssueBook;
            this.issueDate = issueDate;
            this.Department = department;
            this.ContacNo = contacNo;
        }
        public string IssuedBookName { get => issuedBookName; set => issuedBookName = value; }
        public string StuIssueBook { get => stuIssueBook; set => stuIssueBook = value; }
        public string IssueDate { get => issueDate; set => issueDate = value; }
        public string Department { get => department; set => department = value; }
        public string ContacNo { get => contacNo; set => contacNo = value; }

        internal studentIssueBookDL studentIssueBookDL
        {
            get => default;
            set
            {
            }
        }
    }
}
