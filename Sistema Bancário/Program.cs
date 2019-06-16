using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<Conta> Lc = new List<Conta>();
				Conta A = null;
				CPoupanca CP = null;
				CCorrente CC = null;
				int Op = 0;
				do
				{
					Console.Clear();
					Console.WriteLine("========== MENU DE OPÇÕES ==========");
					Console.WriteLine("[1] - Abrir Conta");
					Console.WriteLine("[2] - Consultar saldo");
					Console.WriteLine("[3] - Sacar");
					Console.WriteLine("[4] - Depositar");
					Console.WriteLine("[5] - Mostrar contas");
					Console.WriteLine("[9] - Sair do programa");
					Console.WriteLine("====================================");
					Console.Write("Sua opção: ");
					Op = int.Parse(Console.ReadLine());

					switch (Op)
					{
						case 1:
							Console.Clear();
							Console.WriteLine("========== ENTRADA DE DADOS ==========");
							Console.Write("Número da conta: ");
							int n = int.Parse(Console.ReadLine());
							Console.Write("Nome: ");
							string nome = Console.ReadLine();
							Console.Write("CPF: ");
							string cpf = Console.ReadLine();
							Console.Write("Endereço: ");
							string end = Console.ReadLine();
							Console.Write("Idade: ");
							int id = int.Parse(Console.ReadLine());
							Console.WriteLine("=======================================");
							Console.WriteLine("[1] - Conta Poupança");
							Console.WriteLine("[2] - Conta Corrente");
							Console.Write("Sua opção: ");
							Op = int.Parse(Console.ReadLine());

							if (Op == 1)
							{
								CP = new CPoupanca();
								CP.GravarDados(n, nome, cpf, end, id);
								Lc.Add(CP);
							}
							if (Op == 2)
							{

								CC = new CCorrente();
								CC.GravarDados(n, nome, cpf, end, id);
								Lc.Add(CC);
							}

							break;
						case 2:
							Console.Clear();
							Console.WriteLine("========== CONSULTA DE SALDO ==========");
							Console.Write("Número da conta: ");
							int num = int.Parse(Console.ReadLine());
							string dados = " ";
							foreach (Conta item in Lc)
							{
								if (num == item.Numero)
								{
									dados = item.MostrarDados();
									Console.WriteLine(dados);
									Console.WriteLine("Saldo disponível.....: " + item.Saldo.ToString("R$ 0.00"));
								}
							}
							Console.WriteLine("======================================");
							Console.ReadKey();
							break;

						case 3:
							Console.Clear();
							Console.WriteLine("========== SAQUE ==========");
							Console.Write("Número da conta: ");
							num = int.Parse(Console.ReadLine());
							Console.Write("Valor: ");
							double valor = double.Parse(Console.ReadLine());
							Console.WriteLine();
							foreach (Conta item in Lc)
							{
								if (num == item.Numero)
								{
									dados = item.MostrarDados();
									Console.WriteLine(dados);
									Console.WriteLine();
									item.Sacar(valor);
								}
							}
							break;

						case 4:
							Console.Clear();
							Console.WriteLine("========== DEPOSITO ==========");
							Console.Write("Número da conta: ");
							num = int.Parse(Console.ReadLine());
							Console.Write("Valor: ");
							valor = double.Parse(Console.ReadLine());
							Console.WriteLine();
							foreach (Conta item in Lc)
							{
								if (num == item.Numero)
								{
									dados = item.MostrarDados();
									Console.WriteLine(dados);
									item.Deposita(valor);
								}
							}
							Console.WriteLine("Deposito realizado com sucesso!");
							Console.WriteLine("==============================");
							Console.ReadKey();
							break;

						case 5:
							Console.Clear();
							string aux = " ";
							Console.WriteLine("========== Lista de Contas ==========");
							foreach (Conta item in Lc)
							{
								aux = item.MostrarDados();
								Console.WriteLine(aux);

							}
							Console.WriteLine("====================================");
							Console.ReadKey();
							break;
					}


				} while (Op != 9);

			}
			catch (Exception)
			{

				throw;
			}

		}
	}
}
