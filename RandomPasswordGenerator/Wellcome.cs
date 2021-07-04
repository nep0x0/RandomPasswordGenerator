using System;
using System.Text;


namespace RandomPasswordGenerator
{
	class Wellcome : Generator
	{
		public string tittle = "==PASSWORD GENERATOR==\n";
		public string inputForm = "Input length : ";
		public string input;
		public bool success;
		public int inputValue;
		public void ShowForm()
		{

			Console.SetCursorPosition((Console.WindowWidth - this.tittle.Length) / 2, Console.CursorTop);
			Console.WriteLine(tittle);
			Console.Write(inputForm);
			input = Console.ReadLine();
			success = int.TryParse(input, out inputValue);
			
            while (!success)
            {
				isValid();
            }

			string password = GetRandomPassword(inputValue - 2); // variable penampung hasil dari getrandompassowrd 1(karakter angka dan huruf), inputnya sesuai lenght yang di inginkan user lalu di kurangi 2
			string password2 = GetRandomPassword2(2); //variable penampung hasil dari getrandompassord2 (karakter symbol) inputnya selalu dua karena menurut kami 2 symbol dalam password itu akan membuat password cukup aman
			string password3 = password + password2;
			string passwordResult = GetRandomPassword3(password3);

			Console.WriteLine("\nYour password is " + passwordResult );
			Console.WriteLine(" ");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		public void isValid()
        {
				Console.Clear();
				Console.SetCursorPosition((Console.WindowWidth - this.tittle.Length) / 2, Console.CursorTop);
				Console.WriteLine(tittle);
				Console.WriteLine("Invalid Input, Try to input a Number...\n");
				Console.Write(inputForm);
				input = Console.ReadLine();
				success = int.TryParse(input, out inputValue);
		}
	}

}
