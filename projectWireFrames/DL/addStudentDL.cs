using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using projectWireFrames.BL;
namespace projectWireFrames.DL
{
    class addStudentDL
    {
        private static List<addStudent> studentsList = new List<addStudent>();

        internal static List<addStudent> StudentsList { get => studentsList; set => studentsList = value; }

        public addStudent addStudent
        {
            get => default;
            set
            {
            }
        }

        public static void addStudentRecordIntoList(addStudent student)
        {
            studentsList.Add(student);
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
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
        public static bool readAddStudentDataFromFile(string bookPath)
        {
            if (File.Exists(bookPath))
            {
                StreamReader fileVariable = new StreamReader(bookPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string studentName = parseData(record, 1);
                    string id = parseData(record, 2);
                    string issuedBooks = parseData(record, 3);
                    string returnedBooks = parseData(record, 4);
                    string degree = parseData(record, 5);
                    string semester = parseData(record, 6);
                    addStudent student = new addStudent(studentName, id, issuedBooks, returnedBooks, degree, semester);
                    addStudentDL.addStudentRecordIntoList(student);

                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeStudentIntoFile(addStudent student, string studentPath)
        {
            StreamWriter file = new StreamWriter(studentPath, true);
            file.WriteLine( student.StudentName + "," + student.StudentId + "," + student.IssuedBooks + "," + student.ReturnedBooks + "," + student.Degree + "," + student.Semester);
            file.Flush();
            file.Close();

        }

        public static void deleteStudentFromList(addStudent student)
        {
            for (int index = 0; index < studentsList.Count; index++)
            {
                if (studentsList[index].StudentName == student.StudentName)
                {
                    studentsList.RemoveAt(index);
                }
            }

        }
        public static void EditStudentFromList(addStudent previous, addStudent updated)
        {
            foreach (addStudent student in studentsList)
            {
                if (student.StudentName == previous.StudentName && student.StudentId == previous.StudentId)
                {
                    student.StudentName = updated.StudentName;
                    student.StudentId = updated.StudentId;
                    student.IssuedBooks = updated.IssuedBooks;
                    student.ReturnedBooks = updated.ReturnedBooks;
                    student.Degree = updated.Degree;
                    student.Semester= updated.Semester;
                }
            }

        }
        public static void storeAllStudentDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (addStudent storedStudent in studentsList)
            {
                file.WriteLine(storedStudent.StudentName + "," + storedStudent.StudentId + "," + storedStudent.IssuedBooks + "," + storedStudent.ReturnedBooks + "," + storedStudent.Degree + "," + storedStudent.Semester);


            }
            file.Flush();
            file.Close();

        }

    }
}
