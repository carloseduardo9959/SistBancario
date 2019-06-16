using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	class Conta
	{
		private int numero;
		private Cliente titular;
		private double saldo;

		public Conta()
		{
			titular = new Cliente();
			Saldo = 0;
		}

		public void GravarDados(int num, string nome, string cpf, string endereço, int idade)
		{
			numero = num;
			titular.Gravar(nome, cpf, endereço, idade);
		}

		public string MostrarDados()
		{
			string aux = " ";
			aux = "Número: " + numero + Environment.NewLine;
			aux += "Nome: " + titular.Nome + Environment.NewLine;
			aux += "CPF: " + titular.Cpf + Environment.NewLine;
			aux += "Endereço: " + titular.Endereço + Environment.NewLine;
			aux += "Idade: " + titular.Idade;
			return aux;
		}

		public int Numero { get => numero; set => numero = value; }
		public double Saldo { get => saldo; set => saldo = value; }

		public virtual string MostrarSaldo()
		{
			string aux = "Saldo disponível.....:  " + saldo.ToString("R$ 0.00");
			return aux;
		}


		public void Deposita(double valor_deposito)
		{
			if (valor_deposito > 0)
			{
				Saldo += valor_deposito;

			}
		}
		public virtual void Sacar(double valor)	{}

	}

}
