﻿using System;

namespace _05_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Metodo();
			}
			catch (DivideByZeroException e)
			{

				Console.WriteLine(e.Message);
				
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				
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