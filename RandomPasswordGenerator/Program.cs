using System;
using System.Text;

namespace RandomPasswordGenerator
{
    class Program
    {
		
		/*public static string GetRandomPassword(int length)
		{
			const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; //karakter yang di acak angka, huruf kapital dan kecil

			StringBuilder sb = new StringBuilder(); // StringBuilder Class
			Random rnd = new Random(); // Random Class untuk mengacak chars

			for (int i = 0; i < length; i++)
			{
				int indek = rnd.Next(chars.Length); // rnd.Next akan mengacak dan memilih salah satu indeks dari variable chars "yang di acak dan dipilih adalah nomor indeksnya"
				sb.Append(chars[indek]);  // method Append pada sb akan menambahkan karakter yang sesuai dengan indeks yang terpilih dari variabel indek
			}

			return sb.ToString(); // ini akan mereturn hasil dari looping for di atas ,dan method ToString akan mengkonversi type data ke String karena type data yang di olah sebelumnya adalah StringBuilder
		}


		//Ini adalah method string acak baris 2 terakhir akan menghasilkan karakter symbol, dimana password yang kuat memerlukan setidaknya 1 atau 2 symbl
		public static string GetRandomPassword2(int length)
		{
			const string chars = "!@#$%^&*()-_=+[],.{}:<>?"; // Symbol yang akan di acak

			StringBuilder sb = new StringBuilder();
			Random rnd = new Random();

			for (int i = 0; i < length; i++)
			{
				int indek = rnd.Next(chars.Length); //pengacak symbol
				sb.Append(chars[indek]); //penampung hasil acak symbol
			}

			return sb.ToString(); // hasil acak symbol
		}*/

		public static void Main()
		{
			Wellcome wlcm = new Wellcome();
			wlcm.ShowForm();

			/*Console.WriteLine("==PASSWORD GENERATOR==");
			Console.WriteLine(" ");

			Console.Write("Input length : ");
			int length = int.Parse(Console.ReadLine()) - 2; //input panjang password yang diinginkan user , dikurangi 2 karena ini untuk menyisakan dua kursi kosong untuk karakter symbol

			string password = GetRandomPassword(length); // variable penampung hasil dari getrandompassowrd 1(karakter angka dan huruf), inputnya sesuai lenght yang di inginkan user lalu di kurangi 2

			string password2 = GetRandomPassword2(2); //variable penampung hasil dari getrandompassord2 (karakter symbol) inputnya selalu dua karena menurut kami 2 symbol dalam password itu akan membuat password cukup aman

			Console.WriteLine("\nYour password is " + password + password2);
			Console.WriteLine(" ");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();*/
		}
	}

	/*class Wellcome : Generator
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

	}*/

	/*class Generator
    {
		public static string GetRandomPassword(int length)
		{
			const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; //karakter yang di acak angka, huruf kapital dan kecil

			StringBuilder sb = new StringBuilder(); // StringBuilder Class
			Random rnd = new Random(); // Random Class untuk mengacak chars

			for (int i = 0; i < length; i++)
			{
				int indek = rnd.Next(chars.Length); // rnd.Next akan mengacak dan memilih salah satu indeks dari variable chars "yang di acak dan dipilih adalah nomor indeksnya"
				sb.Append(chars[indek]);  // method Append pada sb akan menambahkan karakter yang sesuai dengan indeks yang terpilih dari variabel indek
			}

			return sb.ToString(); // ini akan mereturn hasil dari looping for di atas ,dan method ToString akan mengkonversi type data ke String karena type data yang di olah sebelumnya adalah StringBuilder
		}


		//Ini adalah method string acak baris 2 terakhir akan menghasilkan karakter symbol, dimana password yang kuat memerlukan setidaknya 1 atau 2 symbl
		public static string GetRandomPassword2(int length)
		{
			const string chars = "!@#$%^&*()-_=+[],.{}:<>?"; // Symbol yang akan di acak

			StringBuilder sb = new StringBuilder();
			Random rnd = new Random();

			for (int i = 0; i < length; i++)
			{
				int indek = rnd.Next(chars.Length); //pengacak symbol
				sb.Append(chars[indek]); //penampung hasil acak symbol
			}

			return sb.ToString(); // hasil acak symbol
		}
	}*/
}
