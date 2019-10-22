using System;

namespace ByteBank
{
	public class OperacaoFinanceiraException : Exception
	{
		public OperacaoFinanceiraException()
		{

		}

		public OperacaoFinanceiraException(string mensagem) : base(mensagem)
		{

		}

		public OperacaoFinanceiraException(string message, Exception excecaoInterna) : base(message, excecaoInterna)
		{
		}
	}
}
