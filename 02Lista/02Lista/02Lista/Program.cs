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
            
            Imagem picture = new Imagem(5,5);          

            Console.WriteLine(picture.Largura);
            Console.WriteLine(picture.Altura);
            Console.WriteLine(picture.pixels[1,1].Blue);

            for (int alt = 0; alt < picture.Altura; alt++)
                for (int larg = 0; larg < picture.Largura; larg++)
                { 
                    Console.WriteLine("Altura: "+alt+", largura: "+larg+", canal de cor red "+picture.pixels[alt, larg].Red);
                    Console.WriteLine("Altura: " + alt + ", largura: " + larg + ", canal de cor green " + picture.pixels[alt, larg].Green);
                    Console.WriteLine("Altura: " + alt + ", largura: " + larg + ", canal de cor blue " + picture.pixels[alt, larg].Blue);
                }

            Console.WriteLine("Aplicando a equivalencia em tons de cinza:");
            picture.EquivalenteCinza(picture);

             /*for (int alt = 0; alt < picture.Altura; alt++)
                for (int larg = 0; larg < picture.Largura; larg++)
                {
                    Console.WriteLine("Altura: " + alt + ", largura: " + larg + ", canal de cor red " + picture.pixels[alt, larg].Red);
                    Console.WriteLine("Altura: " + alt + ", largura: " + larg + ", canal de cor green " + picture.pixels[alt, larg].Green);
                    Console.WriteLine("Altura: " + alt + ", largura: " + larg + ", canal de cor blue " + picture.pixels[alt, larg].Blue);
                }


           CorRgb black = CorRgb.CorPreta();
            picture.MudaPixel(1, 1, black);

            Console.WriteLine("Testando alteracao de cor");
            Console.WriteLine("Altura: " + 1 + ", largura: " + 1 + ", canal de cor red " + picture.pixels[1, 1].Red);
            Console.WriteLine("Altura: " + 1 + ", largura: " + 1 + ", canal de cor green " + picture.pixels[1, 1].Green);
            Console.WriteLine("Altura: " + 1 + ", largura: " + 1 + ", canal de cor blue " + picture.pixels[1, 1].Blue);*/

            Imagem picture2 = new Imagem(3, 3);
            /*for (int alt = 0; alt < picture2.Altura; alt++)
                for (int larg = 0; larg < picture2.Largura; larg++)
                {
                    Console.WriteLine("Altura: " + alt + ", largura: " + larg + ", canal de cor red " + picture2.pixels[alt, larg].Red);
                    Console.WriteLine("Altura: " + alt + ", largura: " + larg + ", canal de cor green " + picture2.pixels[alt, larg].Green);
                    Console.WriteLine("Altura: " + alt + ", largura: " + larg + ", canal de cor blue " + picture2.pixels[alt, larg].Blue);
                }

            Console.WriteLine("Testando a igualdade entre duas imagens");
            Console.WriteLine("Resultado da comparacao: " + picture.VerificaIgualdade(picture, picture2));*/

        }
        
    }
}
