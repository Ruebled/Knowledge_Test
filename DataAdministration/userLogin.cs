using System.IO;
//using System.IO.Enumeration;
using ObjectDefines;
using System.Configuration;
using System;

namespace DataAdministration
{
    public class userLogin
    {
		private string LOGIN_DATA_FILE;
		private const char LOGIN_DATA_FILE_DELIM = ':';

        private string USER_DATA_FILE;


        public userLogin()
		{
			Stream streamTextFile;

            string LoginFileName = ConfigurationManager.AppSettings["LoginFileName"];
            string SolutionFileLocation = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            LOGIN_DATA_FILE = SolutionFileLocation + "\\" + "DATA" + "\\" + LoginFileName;

            streamTextFile = File.Open(LOGIN_DATA_FILE, FileMode.OpenOrCreate);
			streamTextFile.Close();

            string DataFileName = ConfigurationManager.AppSettings["UserDataFile"];
            SolutionFileLocation = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            USER_DATA_FILE = SolutionFileLocation + "\\" + "DATA" + "\\" + DataFileName;

            streamTextFile = File.Open(USER_DATA_FILE, FileMode.OpenOrCreate);
			streamTextFile.Close();
		}

		public User getUser(string username, string password)
		{
			string line;
			StreamReader streamReader;

			string[] userLoginData = System.Array.Empty<string>();

			// Get userID and OcupationID from Login_Data_file
			streamReader = new StreamReader(LOGIN_DATA_FILE, true);

			while ((line = streamReader.ReadLine()) != String.Empty)
			{
				//ID:USERNAME:PASSWORD:ROLE
				userLoginData = line.Trim().Split(LOGIN_DATA_FILE_DELIM);
				if(userLoginData[1] == username && userLoginData[2] == password)
					break;
				userLoginData = Array.Empty<string>();
			}
			streamReader.Close();

			if(userLoginData.Length == 0) return null;

			// Get user data from another file
			streamReader = new StreamReader(USER_DATA_FILE, true);
			while ((line = streamReader.ReadLine()) != String.Empty)
			{
				//ID:EMAIL:FIRST_NAME:SECOND_NAME:BIRTH_DATE:OCUPATION
				string[] userData = line.Trim().Split(LOGIN_DATA_FILE_DELIM);

				//todo TryParse
				//add test for userData if not string throw error or something
				if(Convert.ToInt32(userData[0]) == Convert.ToInt32(userLoginData[0]))
				{
					//Add a enum for these users
					switch(Convert.ToInt32(userLoginData[3]))
					{
						case 1:
							return new Admin(userData);
						case 2:
							return new Prof(userData);
						case 3:
							return new Stud(userData);
						default:
							return null;
					}
				}
			}
			
			streamReader.Close();
			return null;
		}
    }
}
