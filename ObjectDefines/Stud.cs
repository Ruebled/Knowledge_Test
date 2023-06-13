using System;

namespace ObjectDefines
{
	public class Stud : User
	{
		public Stud(){}

		public Stud(string[] data) : base(data)
		{

		}

		public string ToStringUserInfo()
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

