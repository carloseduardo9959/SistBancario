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

		public List<Conta> LCcorrent { get { return lCcorrent; } }

		public void RegConta(Conta A)
		{
			lCcorrent.Add(A);
		}

		public override void Sacar(double valor)
		{
			if (valor > 0 && valor <= Saldo)
			{
				Saldo -= valor + 0.10;
			}
		}
	}
}
