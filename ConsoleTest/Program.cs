using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ObjectDefines;
using DataAdministration;

namespace ConsoleTest
{
	class Program
	{
	//	enum Users {
	//		None,
	//		Administrator,
	//		Profesor,
	//		Student
	//	}

		static void Main(string[] args)
		{
			User user; // Create empty user for further definition
			do
			{
				userLogin tryLogin  = new userLogin();

				do
				{
					Console.Write("Username: ");
					string username = new String(Console.ReadLine());

					Console.Write("Password: ");
					string password = new String(Console.ReadLine());

					//Test for null input and afterward triming
					if(string.IsNullOrWhiteSpace(username)) 
					{
						continue;
					}else{
						username = new String(username.Trim());
					}

					//Test for null input and afterward triming
					if(string.IsNullOrWhiteSpace(password)){
						continue;
					}else{
						password = new String(password.Trim());
					}

					user = tryLogin.getUser(username, password);

					if(user != null) break;

					// Error message
					Console.WriteLine("Username or Password incorect");

				}while(true);

				do
				{
					Console.Clear();
					
					string[] optionsMenu = user.getMenu();

					foreach (string menuOption in optionsMenu)
					{
						Console.WriteLine(menuOption);
					}

					// Get menu option
					string? input = Console.ReadLine();

					//Check for emptyness or anything else of int + convert
					bool result = int.TryParse(input, out int option);

					if(result!=true) continue;

					user.executeOption(option);

					Console.ReadLine();

				}while(true);

			}while(true);

		}
	}
}
