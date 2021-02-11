using System;

namespace Dio.Series
{
    class Program
    {
        static void Main(string[] args)
        {	
			string opcaoUsuario = ObterOpcaoUsuario();
			
			while(opcaoUsuario.ToUpper() != "X")
			{
				switch(opcaoUsuario)
				{
					case "1":
						ListaSeries();
						break;
					case  "2":
						InserirSerie();
						break;
					case  "3":
						AtualizarSerie();
						break;
					case  "4":
						ExcluirSerie();
						break;
					case  "5":
						VisualizarSerie();
						break
					case  "C":
						Console.Clear();
						break;
					default:
						throw new ArgumentOutOfRangerExeception();	
				}
			}	
            Console.WriteLine("Hello World!");
        }
		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Dio Series a seu Dispor!!!!");
			Console.WriteLine("informe a opção desejada:");
			
			Console.WriteLine("1- Listar Series");
			Console.WriteLine("2- Inserir nova Serie");
			Console.WriteLine("3- Atualizar Serie)";
			Console.WriteLine("4- Excluir Serie");
			Console.WriteLine("5- Visualizar Serie");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- sair");
			
			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
