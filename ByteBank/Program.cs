using ByteBank;
using System;

namespace _05_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ContaCorrente conta1 = new ContaCorrente(4564, 789684);
				ContaCorrente conta2 = new ContaCorrente(7891, 456794);

				//conta1.Transferir(10000, conta2);
				conta1.Sacar(10000);
			}
			catch (OperacaoFinanceiraException e)
			{
				Console.WriteLine(e.Message);

				Console.WriteLine(e.StackTrace);

				//Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

				//Console.WriteLine(e.InnerException.Message);
				//Console.WriteLine(e.InnerException.StackTrace);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
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
