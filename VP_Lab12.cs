using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, k, sum=0, max=int.MinValue, min=int.MaxValue;
			Console.WriteLine("Random?");
			bool random = Console.ReadLine().Equals("yes");
			n = int.Parse(Console.ReadLine());
			Random rand = new Random();
			for(int i=0; i<n; i++)
			{
				k = random?rand.Next(1,1000):int.Parse(Console.ReadLine());
				sum += k;
				if (k < min)
					min = k;
				else if (k > max)
					max = k;
			}
			Console.WriteLine("avg="+((decimal)sum/n)+"\nmin="+min+"\nmax="+max);
		}
	}
}
