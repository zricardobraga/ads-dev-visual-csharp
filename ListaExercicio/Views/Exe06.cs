using System;

namespace ListaExercicios.Views
{
	public class Exe04
	{
		public static void Render()
		{
			const int TAM = 100;
			const int LIMITE = 1001;
			
			//instancia a classe Random para gerar valores numericos aleatórios
			Random rand = new Random(); 
			
			//cria um vetor com 100 posições
			int[] numeros = new int[TAM]; 


			// laço para popular o vetor
			for (int i = 0; i < TAM; i++)			
			{
				//gera um número randomico do 0 ao 1000
				numeros = rand.Next(LIMITE);       
			}
			
			//printa os valores do vetor na tela
			foreach (int numero in numeros)			
            {
				Console.Write($"{numero} ");
			}
			
			//ordena o vetor "na mão"
			bool swap = false;
            do
            {
				swap = false;
				for (int i = 0; i < TAM - 1; i++)
				{
					if (numeros[i] > numeros[i + 1])
					{
						int aux = numeros[i];
						numeros[i] = numeros[i + 1];
						numeros[i + 1] = aux;
						swap = true;
					}
				}
			} while (swap);


			//ordena o vetor de forma automática
			Array.Sort(numeros);
			
			//printa os valores ordenados do vetor na tela
			foreach (int numero in numeros)			
			{
				Console.Write($"{numero} ");        
			}

		}
	}
}