namespace _05_ByteBank
{
	class ContaCorrente
	{
		public static int TotalDeContasCriadas { get; private set; }

		private int _agencia;
		public int Agencia
		{
			get
			{
				return _agencia;
			}
			set
			{
				if (value <= 0)
				{
					return;
				}

				_agencia = value;
			}
		}
		public int Numero { get; set; }

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
			this.Agencia = agencia;
			this.Numero = numero;
			ContaCorrente.TotalDeContasCriadas++;
		}

		public void Depositar(double valor)
		{
			this.Saldo += valor;
		}

		public bool Sacar(double valor)
		{
			if (this.Saldo < valor)
			{
				return false;
			}
			this.Saldo -= valor;
			return true;
		}

		public bool Transferir(ContaCorrente contaDestino, double valor)
		{
			if (this.Saldo < valor)
			{
				return false;
			}
			this.Saldo -= valor;

			contaDestino.Depositar(valor);
			return true;
		}
	}
}
