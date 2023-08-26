using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using projectWireFrames.BL;
namespace projectWireFrames.DL
{
    class studentIssueBookDL
    {
        private static List<studentIssueBook> issueBooksList = new List<studentIssueBook>();

        internal static List<studentIssueBook> IssueBooksList { get => issueBooksList; set => issueBooksList = value; }

        public static void addStuIssueBooktoList(studentIssueBook issueBook)
        {
            issueBooksList.Add(issueBook);
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
        public static bool readIssueBookDataFromFile(string bookPath)
        {
            if (File.Exists(bookPath))
            {
                StreamReader fileVariable = new StreamReader(bookPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string bookName = parseData(record, 1);
                    string name = parseData(record, 2);
                    string date = parseData(record, 3);
                    string department = parseData(record, 4);
                    string contactNo = parseData(record, 5);
                    studentIssueBook issueBook = new studentIssueBook(bookName, name, date, department, contactNo);
                    addStuIssueBooktoList(issueBook);

                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeStuIssueBookIntoFile(studentIssueBook issueBook, string studentPath)
        {
            StreamWriter file = new StreamWriter(studentPath, true);
            file.WriteLine(issueBook.IssuedBookName + "/" + issueBook.StuIssueBook + "/" + issueBook.IssueDate + "/" + issueBook.Department + "/" + issueBook.ContacNo );
            file.Flush();
            file.Close();

        }
        public static void deleteIssueBookRecFromList(studentIssueBook student)
        {
            for (int index = 0; index < issueBooksList.Count; index++)
            {
                if (issueBooksList[index].StuIssueBook == student.StuIssueBook)
                {
                    issueBooksList.RemoveAt(index);
                }
            }

        }
        public static void EditIssueBookRecFromList(studentIssueBook previous, studentIssueBook updated)
        {
            foreach (studentIssueBook student in issueBooksList)
            {
                if (student.StuIssueBook == previous.StuIssueBook && student.IssuedBookName== previous.IssuedBookName)
                {
                    student.StuIssueBook = updated.StuIssueBook;
                    student.IssuedBookName= updated.IssuedBookName;
                    student.Department = updated.Department;
                    student.ContacNo = updated.ContacNo;
                    student.IssueDate = updated.IssueDate;
                }
            }

        }
        public static void storeIssueBookRecDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (studentIssueBook storedStudent in issueBooksList)
            {
                file.WriteLine(storedStudent.IssuedBookName + "/" + storedStudent.StuIssueBook + "/" + storedStudent.IssueDate + "/" + storedStudent.Department + "/" + storedStudent.ContacNo);


            }
            file.Flush();
            file.Close();

        }


    }
}
