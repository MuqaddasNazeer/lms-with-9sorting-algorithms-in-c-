using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWireFrames.BL
{
    public class addStudent
    {
        private string studentName;
        private string studentId;
        private string issuedBooks;
        private string returnedBooks;
        private string degree;
        private string semester;

        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentId { get => studentId; set => studentId = value; }
        public string IssuedBooks { get => issuedBooks; set => issuedBooks = value; }
        public string ReturnedBooks { get => returnedBooks; set => returnedBooks = value; }
        public string Degree { get => degree; set => degree = value; }
        public string Semester { get => semester; set => semester = value; }

        internal User User
        {
            get => default;
            set
            {
            }
        }

        public addStudent(string studentName, string studentId, string issuedBooks, string returnedBooks, string degree, string semester)
        {
            this.StudentName = studentName;
            this.StudentId = studentId;
            this.IssuedBooks = issuedBooks;
            this.ReturnedBooks = returnedBooks;
            this.degree = degree;
            this.Semester = semester;
        }
    }
}
