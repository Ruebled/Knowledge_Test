using System;

namespace ObjectDefines
{
	//struct birthDate
	//{
	//	int day;
	//	int month;
	//	int year;
	//}

	public class User
	{
		protected int ID = 0;
		protected string firstName = "";
		protected string lastName = "";
		protected string birthDate = "";
		protected string ocupation = "";

		protected string[] menuOptions = new string[] {};

		public User(){}

		//ID:FIRST_NAME:SECOND_NAME:BIRTH_DATE:OCUPATION
		public User(string[] userData)
		{
			
		}

		public string[] getMenu()
		{
			return new string[] {};
		}

		public void executeOption(int option)
		{
			return;
		}
	}
}

