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
            

            oi.SetAltura(3);
            oi.SetLargura(3);
            Console.WriteLine("Eis o tamanho: " + oi.CalculaTamanho());

            Imagem oi2 = new Imagem(oi.largura*oi.altura);

            //oi.FazImagem(oi.CalculaTamanho());

            for (int alt = 0; alt < oi2.altura; alt++)
                for (int larg = 0; larg < oi2.largura; larg++)
                    for (int r = 0; r < oi2.rgb.Length; r++)
                        Console.WriteLine("Altura: "+alt+", largura: "+larg+", canal de cor "+r+": "+oi2.rgb[r]);
        }
        
    }
}
