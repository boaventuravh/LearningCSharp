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

            double luminosidade = rep.CalcularLuminosidade(rep.red, rep.green, rep.blue);

            Console.WriteLine("A luminosidade para essa composicao de cores eh: " + luminosidade);

        }
    }
}