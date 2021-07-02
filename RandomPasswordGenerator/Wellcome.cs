using System;
using System.Collections.Generic;
using System.Text;

namespace RandomPasswordGenerator
{
	class Wellcome : Generator
	{
		public void ShowForm()
		{
			Console.WriteLine("==PASSWORD GENERATOR==");
			Console.WriteLine(" ");

			Console.Write("Input length : ");
			//int length = int.Parse(Console.ReadLine()) - 2; //input panjang password yang diinginkan user , dikurangi 2 karena ini untuk menyisakan dua kursi kosong untuk karakter symbol

			string input = Console.ReadLine();
			int inputValue;
			bool success = int.TryParse(input, out inputValue);
            while (!success)
            {
				Console.WriteLine("Invalid Input, Try again...");
				Console.Write("Input length: ");
				input = Console.ReadLine();
				success = int.TryParse(input, out inputValue);
            }

			string password = GetRandomPassword(inputValue - 2); // variable penampung hasil dari getrandompassowrd 1(karakter angka dan huruf), inputnya sesuai lenght yang di inginkan user lalu di kurangi 2

			string password2 = GetRandomPassword2(2); //variable penampung hasil dari getrandompassord2 (karakter symbol) inputnya selalu dua karena menurut kami 2 symbol dalam password itu akan membuat password cukup aman

			Console.WriteLine("\nYour password is " + password + password2);
			Console.WriteLine(" ");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

	}

}
