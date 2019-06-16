using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	class Cliente
	{
		private string nome;
		private string cpf;
		private string endereço;
		private int idade;

		public Cliente() { }

		public void Gravar(string nome, string cpf, string endereço, int idade)
		{
			this.nome = nome;
			this.cpf = cpf;
			this.endereço = endereço;
			this.idade = idade;
		}

		public string Nome { get { return nome; } }
		public string Cpf { get { return cpf; } }
		public string Endereço { get { return endereço; } }
		public int Idade { get { return idade; } }
	}
}
