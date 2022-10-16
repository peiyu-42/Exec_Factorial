using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{//計算數值的階乘(Factorial)
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 10;//數值
			int GetFactorial = 1;
			for (int i = 1; i <= number; i++)
			{
				GetFactorial *= i;
			}
			Console.WriteLine($"{number} 的階乘等於 {GetFactorial}");
		}
	}
}
