using System; //o using � o mesmo que o import no java
namespace ListaExercicio.Views
{
    public class Exe01 
    {
        public static void Render() //diferentemente do Java, os m�todos s�o nomeados com a primeira letra maiuscula (pascal case)
        {
            int largura, altura, area;

            Console.Clear;
            Console.WriteLine("Digite a largura: ");
            largura = Convert.ToInt32(Console.ReadLine()); //converte a entrada, que sempre ser� em string, para inteiro 32bits
            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToInt32(Console.ReadLine());
            area = altura * largura;
            Console.WriteLine($"�rea: {area}");
        }
    }
}   