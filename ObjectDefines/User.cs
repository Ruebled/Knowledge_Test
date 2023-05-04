using System;

namespace ObjectDefines
{
	//struct birthDate
	//{
	//	int day;
	//	int month;
	//	int year;
	//}

	enum USERDATA {
		ID = 0,
		FIRST_NAME,
		LAST_NAME,
		BIRTH_DATE,
		OCUPATION		
	}

	public class User
	{
		public int ID { get; set;}
		public string firstName { get; set;}
		public string lastName { get; set;}
		public string birthDate { get; set;} 
		public int ocupation { get; set;}

		protected string[] menuOptions = new string[] {};

		public User(){}

		//ID:FIRST_NAME:SECOND_NAME:BIRTH_DATE:OCUPATION
		public User(string[] userData)
		{
			ID = Convert.ToInt32(userData[(int)USERDATA.ID]);
			firstName = userData[(int)USERDATA.FIRST_NAME];
			lastName = userData[(int)USERDATA.LAST_NAME];
			birthDate = userData[(int)USERDATA.BIRTH_DATE];
			ocupation = Convert.ToInt32(userData[(int)USERDATA.OCUPATION]);
		}

		public virtual string[] getMenu()
		{
			return new string[] {};
		}
	}
}

