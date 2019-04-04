using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		private static void Min(out int min, int[] a)
		{
			min = int.MaxValue;
			foreach (int i in a)
				if (i < min) min = i;
		}
		private static void Max(out int max, int[] a)
		{
			max = int.MinValue;
			foreach (int i in a)
				if (i > max) max = i;
		}
		private static void Avg(out decimal avg, int[] a)
		{
			avg = 0;
			foreach(int i in a)
			{
				avg += i;
			}
			avg /= a.Length;
		}
		static void Main(string[] args)
		{
			int n, k, max = int.MinValue, min = int.MaxValue;
			decimal avg;
			Console.WriteLine("Random?");
			bool random = Console.ReadLine().Equals("yes");
			Console.WriteLine("Vnesi go brojot na elementi");
			n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			Random rand = new Random();
			for (int i = 0; i < n; i++)
			{
				k = random ? rand.Next(1, 1000) : int.Parse(Console.ReadLine());
				a[i] = k;
			}
			Min(out min,a);
			Max(out max, a);
			Avg(out avg,a);
			Console.WriteLine("avg=" + avg + "\nmin=" + min + "\nmax=" + max);
		}
	}
}
