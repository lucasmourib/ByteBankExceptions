﻿namespace _05_ByteBank
{
	class Cliente
	{
		public string Nome { get; set; }
		public string Profissao { get; set; }
		private string _cpf = "0";
		public string Cpf
		{
			get { return _cpf; }
			set
			{
				if (value != null)
				{
					_cpf = value;
				}
			}
		}
	}
}
