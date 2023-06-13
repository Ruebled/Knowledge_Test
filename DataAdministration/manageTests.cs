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
            string SolutionFileLocation = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			TESTS_DIR = SolutionFileLocation + "\\" + "DATA" + "\\" + "TESTS" + "\\";

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

		public void AddTestToFile(Test test){
            using (StreamWriter streamWriterFisierText = new StreamWriter(TESTS_DIR+test.TestFileName, true))
            {
                streamWriterFisierText.WriteLine(test.ToFileStringConvert());
            }
		}

        public void AddTestsToFile(List<Test> tests)
        {
            foreach(Test test in tests)
            {
                AddTestToFile(test);
            }
        }

        public void DeleteTest(Test test_t)
		{
            
            List<Test> test_list = GetTests();

            foreach (Test test in test_list)
            {
                if (test == test_t)
                {
                    test_list.Remove(test);
                    break;
                }
            }

            AddTestsToFile(test_list);
            
            File.Delete(TESTS_DIR+test_t.TestFileName);
		}
   

    }
}
