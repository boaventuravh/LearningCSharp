using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001Lista
{
    class Program
    {
        static void Main()
        {
            Rgb rep = new Rgb();
            rep.SetRed(11); // valor de rep.red
            rep.SetGreen(10); // valor de rep.green
            rep.SetBlue(25); // valor de rep.blue

            Rgb repDois = new Rgb();        
            repDois.SetRed(50); // valor de repDois.red
            repDois.SetGreen(60); // valor de repDois.green
            repDois.SetBlue(70); // valor de repDois.blue
            
            double luminosidade = rep.CalcularLuminosidade(rep.red, rep.green, rep.blue);
            Console.WriteLine("A luminosidade para essa composicao de cores eh: " + luminosidade);

            double lumiDois = repDois.CalcularLuminosidade(repDois.red, repDois.green, repDois.blue);
            Console.WriteLine("A luminosidade para essa composicao de cores eh: " + lumiDois);
            
            Rgb copia = new Rgb(rep);
            Console.WriteLine("Copia das cores: " + copia.red + ", " + copia.green + " e " + copia.blue +".");

            bool comparar;

            comparar = rep.ComparaCores(rep, copia);

            Console.WriteLine("Valor da comparação: " + comparar);
            
            int vermelho = rep.GetRed(rep);
            int verde = rep.GetGreen(rep);
            int azul = rep.GetBlue(rep);

            Console.WriteLine("red: " + vermelho +" green: " + verde + " blue: " + azul);
        }
    }
}