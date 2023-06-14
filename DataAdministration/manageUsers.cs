using System.IO;
//using System.IO.Enumeration;
using ObjectDefines;
using System.Configuration;
using System;
using System.Collections.Generic;
using ObjectDefines;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

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
                    if(linieFisier == string.Empty)
                    {
                        return users;
                    }
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

        public void DeleteUser(User user_t)
        {
            
            List<User> user_list = GetUsers();
            List<User> user_list_tmp = new List<User>();

            using (StreamWriter streamWriterFisierText = new StreamWriter(USERS_DATA_FILE, false)) { }

            foreach (User user in user_list)
            {
                if(user.ID != user_t.ID)
                {
                    user_list_tmp.Add(user);
                }
            }

            AddUsersToFile(user_list_tmp);
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
