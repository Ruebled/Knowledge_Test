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
        //private const char TESTS_FILE_DELIM_CORECT = ':';
        //private const string TESTS_FILE_DELIM_QUESTION = "---";
        //private const string TESTS_FILE_DELIM_TESTS = "===";
		private const string TESTS_DIR;

        public ManageTests()
        {
            Stream streamTextFile;

            //string DataFileName = ConfigurationManager.AppSettings["TestsFileName"];
            string SolutionFileLocation = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //TESTS_DATA_FILE = SolutionFileLocation + "\\" + "DATA" + "\\" + DataFileName;
			TESTS_DIR = SolutionFileLocation + "\\" + "DATA" + "TESTS" + "\\";

            streamTextFile = File.Open(TESTS_DATA_FILE, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }

        public List<Test> GetTests()
        {
            //string line;
            //StreamReader streamReader;

            //streamReader = new StreamReader(TESTS_DATA_FILE, true);

            List<Test> TestsData = new List<Test>();

			string[] TestsFoundFiles = Directory.GetFiles(TESTS_DIR, "*.txt");
			
			foreach(string f in TestsFoundFiles)
			{
				List<string> Test_data = streamReader.ReadAllLines(f).ToList();
				TestsData.Add(Test(Test_data, f));
			}

            //streamReader.Close();

			if(TestsData.Length == 0)
			{
				return null;
			}

			return TestsData;
        }
    }
}
