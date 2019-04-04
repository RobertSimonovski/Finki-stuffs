using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

	
class Program
	{
		enum PasswordStrenght : byte
		{
			easy = 1,
			normal = 2,
			hard = 3
		}
		private static string generatePassword(PasswordStrenght passwordStrenght)
		{
			Random random = new Random();
			string chars = "abcdefghijklmnopqrstuvwxyz";
			char[] stringChars = new char[6];
			if (passwordStrenght == (PasswordStrenght)3)
			{
				chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+?/\\|";
				stringChars = new char[random.Next(10, 25)];
			}
			else if(passwordStrenght == (PasswordStrenght)2)
			{
				chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
				stringChars = new char[random.Next(6,10)];
			}

			for (int i = 0; i < stringChars.Length; i++)
			{
				stringChars[i] = chars[random.Next(chars.Length)];
			}

			return new String(stringChars);
		}

		static void Main(string[] args)
		{
			string password = generatePassword((PasswordStrenght)byte.Parse(Console.ReadLine()));
			string userPasswords = Console.ReadLine();
			string[] passwords = userPasswords.Split(' ');
			foreach (string userpw in passwords)
				if (password.Equals(userpw))
				{
					Console.WriteLine("gratz");
					return;
				}
			Console.WriteLine("Better luck next time \n"+password);
		}
	}
}
