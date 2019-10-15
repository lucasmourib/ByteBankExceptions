using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceptions
{
	class SaldoInsuficienteException : Exception
	{
		public double Saldo { get; }
		public double ValorSaque { get; }

		public SaldoInsuficienteException()
		{

		}
	
		public SaldoInsuficienteException(string mensagem) : base (mensagem)
		{

		}

		public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque no valor de" + valorSaque + " com saldo de " + saldo)
		{
			this.Saldo = saldo;
			this.ValorSaque = valorSaque;
		}
	}
}
