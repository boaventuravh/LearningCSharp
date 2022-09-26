using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Lista
{
    class Program
    {
        static void Main()
        {
            Imagem oi = new Imagem();
            

            oi.Altura = 2;
            oi.Largura = 3;
            Console.WriteLine("Eis o tamanho: " + oi.CalculaTamanho());

            Imagem oi2 = new Imagem(3,3);
                       

            for (int alt = 0; alt < oi2.Altura; alt++)
                for (int larg = 0; larg < oi2.Largura; larg++)
                        Console.WriteLine("Altura: "+alt+", largura: "+larg+", canal de cor red "+oi2.pixels[alt, larg]);
        }
        
    }
}
