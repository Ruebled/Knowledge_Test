using System;

namespace ObjectDefines
{
	public class Prof : User
	{
		public Prof(){}

		public Prof(string[] data) : base(data)
		{

		}

		public override string[] getMenu()
		{
			return new string[] {};
		}
	}
}


