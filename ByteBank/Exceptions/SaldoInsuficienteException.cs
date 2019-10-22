namespace ByteBank.Exceptions
{
	public class SaldoInsuficienteException : OperacaoFinanceiraException
	{
		public double Saldo { get; }
		public double ValorSaque { get; }

		public SaldoInsuficienteException()
		{

		}

		public SaldoInsuficienteException(string mensagem) : base(mensagem)
		{

		}

		public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque no valor de " + valorSaque + " com saldo de " + saldo)
		{
			this.Saldo = saldo;
			this.ValorSaque = valorSaque;
		}
	}
}
