using System;

namespace ListaExercicios.Views
{
	public class Exe03
	{
		public static void Render()
		{
			int num1, num2;
			Console.WriteLine("Digite o primeiro número: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o segundo número: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			if (num1 > num2){
				Console.WriteLine("O primeiro número é o maior!");
			}else{
				Console.WriteLine("O segundo número é o maior!");
			}
		}
	}
}
