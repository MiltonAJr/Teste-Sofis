using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
     		int menorMultiploTotalAte = MenorMultiploTotalAte(10);

			Console.WriteLine("");

			Console.WriteLine("Qual o menor número positivo que é divisível por todos os números de 1 a 10?");
			
			Console.WriteLine();

	     	Console.WriteLine("Resultado:" + menorMultiploTotalAte);

			Console.WriteLine();

			menorMultiploTotalAte = MenorMultiploTotalAte(20);

			Console.WriteLine("");

			Console.WriteLine("Qual o menor número positivo que é divisível por todos os números de 1 a 20?");

			Console.WriteLine();

			Console.WriteLine("Resultado:" + menorMultiploTotalAte);

			Console.ReadKey(false);
		}

			public static int MenorMultiploTotalAte(int limite)
			{
				//Lista da menor quantidade de cada fator primo para representar numeros 
				List<int> fatores = new List<int>();

				for (int numero = 1; numero <= limite; numero++)
				{
					//Confere se o numero atual consegue ser representado pelos fatores da lista
					int curr = numero;
					foreach (int fator in fatores)
					{
						if (curr % fator == 0)
							curr = curr / fator;
					}

					//Se os fatores não foram suficientes para representar o numero atual, adiciona o necessário
					if (curr != 1)
						fatores.Add(curr);
				}

				//Multiplica os fatores encontrados
				int total = 1;
				foreach (int fator in fatores)
					total *= fator;

				return total;

			}
		}
}
