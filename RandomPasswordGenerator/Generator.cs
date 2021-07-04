using System;
using System.Collections.Generic;
using System.Text;

namespace RandomPasswordGenerator
{
	class Generator
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
			const string chars = " !\"#$%&'()*+,-./:;<=>?@[]\\^_`{|}~"; // Symbol yang akan di acak

			StringBuilder sb = new StringBuilder();
			Random rnd = new Random();

			for (int i = 0; i < length; i++)
			{
				int indek = rnd.Next(chars.Length); //pengacak symbol
				sb.Append(chars[indek]); //penampung hasil acak symbol
			}

			return sb.ToString(); // hasil acak symbol
		}

		public static string GetRandomPassword3(string password3)
		{
			string chars = password3; // Symbol yang akan di acak

			StringBuilder sb = new StringBuilder();
			Random rnd = new Random();

			for (int i = 0; i < chars.Length; i++)
			{
				int indek = rnd.Next(chars.Length); //pengacak symbol
				sb.Append(chars[indek]); //penampung hasil acak symbol
			}

			return sb.ToString(); // hasil acak symbol
		}
	}
}
