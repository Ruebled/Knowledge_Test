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
		EMAIL,
        PASSWORD,
        FIRST_NAME,
		LAST_NAME,
		BIRTH_DATE,
		OCUPATION
	}



	public class User
	{
		private const char USER_DATA_FILE_DELIM = ':';

		public int ID { get; set; }
		public string email { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string birthDate { get; set; }
		public int ocupation { get; set; }

		public string password { get; set; }

		public User() { }

		//ID:EMAIL:FIRST_NAME:SECOND_NAME:BIRTH_DATE:OCUPATION

		public User(string userData_line)
		{
            string[] userData = userData_line.Trim().Split(USER_DATA_FILE_DELIM);

            ID = Convert.ToInt32(userData[(int)USERDATA.ID]);
			email = userData[(int)USERDATA.EMAIL];
            password = userData[(int)USERDATA.PASSWORD];
            firstName = userData[(int)USERDATA.FIRST_NAME];
			lastName = userData[(int)USERDATA.LAST_NAME];
			birthDate = userData[(int)USERDATA.BIRTH_DATE];
			ocupation = Convert.ToInt32(userData[(int)USERDATA.OCUPATION]);
		}


		public virtual string ToStringFileFormat()
		{
            return String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}",
                this.ID,
                this.email,
                this.firstName,
                this.lastName,
                this.birthDate,
                this.ocupation
                );
        }
	}
}

