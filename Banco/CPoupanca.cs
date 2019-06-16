using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	class CPoupanca:Conta
	{
		protected List<Conta> lCPoup;

		public List<Conta> LCPoup { get { return LCPoup; } }

		public void RegConta(Conta A)
		{
			lCPoup.Add(A);
		}

		public override void Sacar(double valor)
		{
			if (valor > 0 && valor <= Saldo) 
			{
				Saldo -= valor;
			}
		}
	}
}
