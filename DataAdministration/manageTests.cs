using System.IO;
//using System.IO.Enumeration;
using ObjectDefines;
using System.Configuration;
using System;
using System.Collections.Generic;

namespace DataAdministration
{
    public class ManageTests
    {
        private string TESTS_DATA_FILE;
        private const char TESTS_FILE_DELIM_CORECT = ':';
        private const string TESTS_FILE_DELIM_QUESTION = "---";
        private const string TESTS_FILE_DELIM_TESTS = "===";

        public ManageTests()
        {
            Stream streamTextFile;

            string DataFileName = ConfigurationManager.AppSettings["TestsFileName"];
            string SolutionFileLocation = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            TESTS_DATA_FILE = SolutionFileLocation + "\\" + "DATA" + "\\" + DataFileName;

            streamTextFile = File.Open(TESTS_DATA_FILE, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }

        public List<Test> GetTests()
        {
            string line;
            StreamReader streamReader;

            List<Test> TestsData = new List<Test>();

            streamReader = new StreamReader(TESTS_DATA_FILE, true);

            while (true)
            {
                //Test Name
                //---
                //Question
                //0:answer1
                //0:answer2
                //1:answer3
                //=== //end test
                Test test = new Test();

                line = streamReader.ReadLine();

                if (line != String.Empty)
                {
                    test.Name = line;
                }

                line = streamReader.ReadLine();

                Question question = new Question();

                while (line != TESTS_FILE_DELIM_TESTS)
                {
                    while (line != TESTS_FILE_DELIM_QUESTION)
                    {

                    }

                }
                break;



                userLoginData = line.Trim().Split(LOGIN_DATA_FILE_DELIM);
                if (userLoginData[1] == username && userLoginData[2] == password)
                    break;
                userLoginData = Array.Empty<string>();
            }
            streamReader.Close();

            if (userLoginData.Length == 0) return null;

            // Get user data from another file
            streamReader = new StreamReader(USER_DATA_FILE, true);
            while ((line = streamReader.ReadLine()) != String.Empty)
            {
                //ID:EMAIL:FIRST_NAME:SECOND_NAME:BIRTH_DATE:OCUPATION
                string[] userData = line.Trim().Split(LOGIN_DATA_FILE_DELIM);

                //todo TryParse
                //add test for userData if not string throw error or something
                if (Convert.ToInt32(userData[0]) == Convert.ToInt32(userLoginData[0]))
                {
                    //Add a enum for these users
                    switch (Convert.ToInt32(userLoginData[3]))
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
