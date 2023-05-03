using System.IO;
using ObjectDefines;

namespace DataAdministration
{
    public class userLogin
    {
		private const string LOGIN_DATA_FILE = "login_credentials.txt";
		private const string USER_DATA_FILE = "user_data.txt";
		private const string LOGIN_DATA_FILE_DELIM = ":";

		public userLogin()
		{
			Stream streamTextFile;

			streamTextFile = File.Open(LOGIN_DATA_FILE, FileMode.OpenOrCreate);
			streamTextFile.Close();

			streamTextFile = File.Open(USER_DATA_FILE, FileMode.OpenOrCreate);
			streamTextFile.Close();
		}

		public User getUser(string username, string password)
		{
			string?	line;
			StreamReader streamReader;

			string?[] userLoginData = new string[] {};

			// Get userID and OcupationID from Login_Data_file
			streamReader = new StreamReader(LOGIN_DATA_FILE, true);
			while ((line = new String(streamReader.ReadLine())) != String.Empty)
			{
				//ID:USERNAME:PASSWORD:ROLE
				userLoginData = line.Trim().Split(LOGIN_DATA_FILE_DELIM);
				if(userLoginData[1] == username && userLoginData[2] == password)
					break;
				userLoginData = new string[] {};
			}
			streamReader.Close();

			if(userLoginData.Length == 0) return null;

			// Get user data from another file
			streamReader = new StreamReader(USER_DATA_FILE, true);
			while ((line = new String(streamReader.ReadLine())) != String.Empty)
			{
				//ID:FIRST_NAME:SECOND_NAME:BIRTH_DATE:OCUPATION
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
							break;
						case 2:
							return new Prof(userData);
							break;
						case 3:
							return new Stud(userData);
							break;
						default:
							return null;
							break;
					}
				}
			}
			
			streamReader.Close();
			return null;
		}
    }
}
