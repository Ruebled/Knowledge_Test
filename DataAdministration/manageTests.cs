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
    public class ManageTests
    {
		private string TESTS_DIR;

        public ManageTests()
        {
            //Stream streamTextFile;

            //string DataFileName = ConfigurationManager.AppSettings["TestsFileName"];
            string SolutionFileLocation = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //TESTS_DATA_FILE = SolutionFileLocation + "\\" + "DATA" + "\\" + DataFileName;
			TESTS_DIR = SolutionFileLocation + "\\" + "DATA" + "\\" + "TESTS" + "\\";

            // streamTextFile = File.Open(TESTS_DIR, FileMode.OpenOrCreate);
            //streamTextFile.Close();
        }

        public List<Test> GetTests()
        {
            List<Test> TestsData = new List<Test>();

			string[] TestsFoundFiles = Directory.GetFiles(TESTS_DIR, "*.txt");
			
			foreach(string f in TestsFoundFiles)
			{
				List<string> Test_data = File.ReadAllLines(f).ToList();
                Test t_test = new Test(Test_data, f);
				TestsData.Add(t_test);
			}

			if(TestsData.Count == 0)
			{
				return null;
			}

			return TestsData;
        }
   

    }
}
