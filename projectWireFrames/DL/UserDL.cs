using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectWireFrames.BL;
using System.IO;
namespace projectWireFrames.DL
{
    class UserDL
    {
        private static List<User> usersList = new List<User>();

        internal static List<User> UsersList { get => usersList; set => usersList = value; }

        public static void addUserIntoList(User user)
        {
            UsersList.Add(user);
        }

        public static User SignIn(User user)
        {
            foreach (User storedUser in UsersList)
            {
                if (storedUser.UserName == user.UserName && storedUser.UserPassword == user.UserPassword)
                {
                    return storedUser;
                }
            }
            return null;
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
        public static bool readDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string userName = parseData(record, 1);
                    string userPassword = parseData(record, 2);
                    string userRole = parseData(record, 3);
                    User user = new User(userName, userPassword, userRole);
                    addUserIntoList(user);
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeUserIntoFile(User user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.UserName + "," + user.UserPassword + "," + user.UserRole);
            file.Flush();
            file.Close();

        }

        
    }
}
