using System;

namespace _05_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ContaCorrente conta = new ContaCorrente(456, 0);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.ParamName);
			}

			Console.ReadLine();
		}

		static void Metodo()
		{
			TestaDivisor(0);

		}

		static void TestaDivisor(int divisor)
		{
			Dividir(10, divisor);
		}
		public static int Dividir(int numero, int divisor)
		{
			try
			{			
				return numero / divisor;
			}

			catch (Exception)
			{
				Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
				throw;
			}
		}
	}
}
