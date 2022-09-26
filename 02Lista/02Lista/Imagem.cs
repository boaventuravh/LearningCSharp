using _02Lista;
using System;

public class Imagem
{
    //atributos
    public int tamanho;
    public CorRgb[,] pixels;

    public int Largura {get; set;}

    public int Altura { get; set; }
    //métodos
    /*public void SetLargura(int largura)
    {
        this.largura = largura;
    }
    public void SetAltura(int altura)
    {
        this.altura = altura;
    }*/



    public int CalculaTamanho()
    {
        this.tamanho = this.Altura * this.Largura;
        return this.tamanho;
    }

    /* public int[,,] FazImagem(int tamanho)
     {
         tamanho = this.tamanho;
         int largura = tamanho / this.altura;
         int altura = tamanho / this.largura;
         int[,,] pixel = new int[altura, largura, this.rgb.Length];
         for (int alt = 0; alt < altura; alt++)
             for (int larg = 0; larg < largura; larg++)
                 for (int r = 0; r < this.rgb.Length; r++)
                     this.rgb[r] = 255;
         return pixel;
     }*/

    //construtores
    public Imagem() { }
    // no construtor abaixo eu estou considerando tamanho = largura * altura. Referente ao item ii da segunda parte da lista
    public Imagem(int largura, int altura) // todos os pixels ajustados para branco
    {
        this.pixels = new CorRgb[largura, altura];

        for (int indexLargura= 0; indexLargura < largura; indexLargura++)
        {
            for (int indexAltura= 0; indexAltura < altura; indexAltura++)
            {
                this.pixels[largura, altura] = CorRgb.CorBranca();
            }
        }
    }


    //item iii da segunda parte da lista

    public void MudaPixel(int altura, int largura, CorRgb cor)
    {
        this.pixels[altura, largura] = cor;
    }

}
