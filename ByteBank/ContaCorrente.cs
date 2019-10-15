using ByteBank.Exceptions;
using System;

namespace _05_ByteBank
{
	class ContaCorrente
	{
		public static int TotalDeContasCriadas { get; private set; }
		public static int TaxaOperacao { get; private set; }


		public int Agencia { get; }
		public int Numero { get; }

		private double _saldo;
		public double Saldo
		{
			get
			{
				return _saldo;
			}
			set
			{
				if (value < 0)
				{
					return;
				}

				_saldo = value;
			}
		}
		public Cliente Titular { get; set; }
		public ContaCorrente(int agencia, int numero)
		{

			if (agencia <= 0)
			{
				throw new ArgumentException("O argumentoagencia deve ser maior que 0.", nameof(agencia));
			}
			if (numero <= 0)
			{
				throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
			}

			this.Agencia = agencia;
			this.Numero = numero;

			TotalDeContasCriadas++;
			TaxaOperacao = 30 / TotalDeContasCriadas;
		}

		public void Depositar(double valor)
		{
			this.Saldo += valor;
		}

		public void Sacar(double valor)
		{
			if (valor < 0)
			{
				throw new ArgumentException("O valor inválido para saque ", nameof(valor));
			}

			if (this.Saldo < valor)
			{
				throw new SaldoInsuficienteException(_saldo, valor);
			}

			this.Saldo -= valor;

		}

		public void Transferir(ContaCorrente contaDestino, double valor)
		{
			if (valor < 0)
			{
				throw new ArgumentException("O valor inválido para transferência ", nameof(valor));
			}

			this.Sacar(valor);
			contaDestino.Depositar(valor);
		}
	}
}
