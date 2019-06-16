using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	class CCorrente : Conta
	{
		protected List<Conta> lCcorrent;
		private double limite;

		public CCorrente()
		{
			limite = 500.00;
		}

		public List<Conta> LCcorrent { get { return lCcorrent; } }

		public double Limite { get => limite; }

		public void RegConta(Conta A)
		{
			lCcorrent.Add(A);
		}

		public override string MostrarSaldo()
		{
			double r = limite + Saldo;
			string aux = "Limite disponível.....: " + limite.ToString("R$ 0.00") + Environment.NewLine;
			aux += "Saldo total disponível.....: " + r.ToString("R$ 0.00");
			return base.MostrarSaldo() + Environment.NewLine + aux;
		}

		public override void Sacar(double valor)
		{
			if (valor > 0 && valor <= Saldo + Limite)
			{
				Saldo -= valor + 0.10;
			}
			else
			{
				Console.WriteLine("Saldo indisponível !!!");
			}
		}
	}
}
