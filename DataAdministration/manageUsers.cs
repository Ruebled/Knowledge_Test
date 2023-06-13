using System.IO;
//using System.IO.Enumeration;
using ObjectDefines;
using System.Configuration;
using System;
using System.Collections.Generic;
using ObjectDefines;
using System.Linq;

namespace DataAdministration
{
    public class ManageUsers
    {
        private string USERS_DATA_FILE;

        public ManageUsers()
        {
            Stream streamTextFile;

            string DataFileName = ConfigurationManager.AppSettings["UserDataFile"];
            string SolutionFileLocation = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
           
            USERS_DATA_FILE = SolutionFileLocation + "\\" + "DATA" + "\\" + DataFileName;

            streamTextFile = File.Open(USERS_DATA_FILE, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (StreamReader streamReader = new StreamReader(USERS_DATA_FILE))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    users.Add(new User(linieFisier));
                }
            }
            return users;
        }

        public void AddUserToFile(User user)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(USERS_DATA_FILE, true))
            {
                streamWriterFisierText.WriteLine(user.ToStringFileFormat());
            }
        }

        public void DeleteUser(User user)
        {
            List<User> stud_list = GetUsers();

            foreach(User stud in stud_list)
            {
                if(stud == user)
                {
                    stud_list.Remove(stud);
                    break;
                }
            }

            AddUsersToFile(stud_list);
        }

        public void AddUsersToFile(List<User> user_list)
        {
            foreach(User user in user_list)
            {
                AddUserToFile(user);
            } 
        }      
    }
}
