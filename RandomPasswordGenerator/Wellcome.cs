using System;
using System.Collections.Generic;
using System.Text;


namespace RandomPasswordGenerator
{
	class Wellcome : Generator
	{
		public static string input;
		public static bool success;
		public static string tittle;
		public static int inputValue;
		public void ShowForm()
		{
			tittle = "==PASSWORD GENERATOR==\n";
			Console.WriteLine(tittle);
			Console.Write("Input length : ");
		
			input = Console.ReadLine();
			success = int.TryParse(input, out inputValue);
			
            while (!success)
            {
				isValid();
				/*Console.Clear();
				Console.WriteLine(tittle);
				Console.WriteLine("Invalid Input, Try to input a Number...\n");
				Console.Write("Input length: ");
				input = Console.ReadLine();
				success = int.TryParse(input, out inputValue);*/
            }

			string password = GetRandomPassword(inputValue - 2); // variable penampung hasil dari getrandompassowrd 1(karakter angka dan huruf), inputnya sesuai lenght yang di inginkan user lalu di kurangi 2

			string password2 = GetRandomPassword2(2); //variable penampung hasil dari getrandompassord2 (karakter symbol) inputnya selalu dua karena menurut kami 2 symbol dalam password itu akan membuat password cukup aman

			Console.WriteLine("\nYour password is " + password + password2);
			Console.WriteLine(" ");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		public static void isValid()
        {
				Console.Clear();
				Console.WriteLine(tittle);
				Console.WriteLine("Invalid Input, Try to input a Number...\n");
				Console.Write("Input length: ");
				input = Console.ReadLine();
				success = int.TryParse(input, out inputValue);
		}
	}

}
