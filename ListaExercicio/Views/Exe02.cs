using System;

namespace ListaExercicios.Views 
{
	public class Exe02
	{
		public static void Render()
		{
			double real, dolar, euro, pesoArg;
			Console.WriteLine("Digite o valor em R$: ");
			real = Convert.ToDouble(Console.ReadLine());
			dolar = real / 5.17;
			Console.WriteLine($"Dólar: { dolar.ToString("F2") }"); //dolar.ToString arredonda o valor(F é o tipo que para ser formatado, no caso float, e o 2 informa quantas casas decimais (0,00)



		}
	}
}

