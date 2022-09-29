using _02Lista;
using System;

public class Imagem
{
    //atributos
    public int tamanho;
    public CorRgb[,] pixels;

    public int Largura {get; set;}

    public int Altura {get; set;}
    //métodos
    /*public void SetLargura(int largura)
    {
        this.largura = largura;
    }
    public void SetAltura(int altura)
    {
        this.altura = altura;
    }*/



    public int CalculaTamanho(Imagem pic)
    {
        pic.tamanho = pic.Altura * pic.Largura;
        return pic.tamanho;
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
        this.Largura = largura;
        this.Altura = altura;
        this.pixels = new CorRgb[largura, altura];

        for (int indexLargura= 0; indexLargura < largura; indexLargura++)
        {
            for (int indexAltura= 0; indexAltura < altura; indexAltura++)
            {
                this.pixels[indexLargura, indexAltura] = CorRgb.CorBranca(); 
            }
        }
    }


    //item iii da segunda parte da lista

    public void MudaPixel(int altura, int largura, CorRgb cor)
    {
        this.pixels[altura, largura] = cor;
    }

    // referente ao item iv
    public void MudaPixel(int altura, int largura, int red, int green, int blue)
    {
        CorRgb cor = new CorRgb(red, green, blue);
        this.MudaPixel(altura, largura, cor);
    }

    // o método abaixo é referente ao item v da lista
    public bool VerificaIgualdade(Imagem picture1, Imagem picture2)
    {

        picture1.tamanho = CalculaTamanho(picture1);
        picture2.tamanho = CalculaTamanho(picture2);
        int larguraMaior = picture1.Largura;
        int alturaMaior = picture1.Altura;
        if (picture1.tamanho > picture2.tamanho)
        {
            larguraMaior = picture1.Largura;
            alturaMaior = picture1.Altura;
            Console.WriteLine("Parei no primeiro if");
            return false;
        }

        else if (picture1.tamanho < picture2.tamanho)
        {
            larguraMaior = picture2.Largura;
            alturaMaior = picture2.Altura;
            Console.WriteLine("Parei no else if");
            return false;
        }

        else
        {
            for (int indexLargura = 0; indexLargura < larguraMaior; indexLargura++)
                for (int indexAltura = 0; indexAltura < alturaMaior; indexAltura++)
                {
                    if (picture1.pixels[indexLargura, indexAltura].Red != picture2.pixels[indexLargura, indexAltura].Red)
                        return false;
                    else if (picture1.pixels[indexLargura, indexAltura].Green != picture2.pixels[indexLargura, indexAltura].Green)
                        return false;
                    else if (picture1.pixels[indexLargura, indexAltura].Blue != picture2.pixels[indexLargura, indexAltura].Blue)
                        return false;   
                }
        }
        return true; 
        /*lembrando que a execução do loop é interrompida assim  que um valor é retornado*/
    }

    // o método abaixo é referente ao item vi da lista
    public void EquivalenteCinza(Imagem cor)
    {
        for (int indexLargura = 0; indexLargura < cor.Largura; indexLargura++)
        {
            for (int indexAltura = 0; indexAltura < cor.Altura; indexAltura++)
            {
                double dobRed, dobGreen, dobBlue;
                dobRed = cor.pixels[indexLargura,indexAltura].Red;
                dobGreen = cor.pixels[indexLargura, indexAltura].Green;
                dobBlue = cor.pixels[indexLargura, indexAltura].Blue;
                double luminosidade = Math.Truncate(dobRed * 0.3 + dobGreen * 0.59 + dobBlue * 0.11);
                cor.pixels[indexLargura, indexAltura].Red = (int)luminosidade;
                cor.pixels[indexLargura, indexAltura].Green = (int)luminosidade;
                cor.pixels[indexLargura, indexAltura].Blue = (int)luminosidade;
            }
        }
        
    }
    
    // método abaixo: referente ao item vii. da lista
    public bool Fragmento(Imagem maior, Imagem menor)
    {
        if (maior.Altura < menor.Altura || maior.Largura < menor.Largura)
            return false;
        
        int larguraComparacao = 0;
        int alturaComparacao = 0;
        bool igualdade = true;
        while (larguraComparacao < maior.Largura - menor.Largura && alturaComparacao < maior.Largura - menor.Largura)
        {      
            for (int indexLargura = 0, indexLarguraComparacao = larguraComparacao; indexLargura < menor.Largura; indexLargura++, indexLarguraComparacao++)
                for (int indexAltura = 0, indexAlturaComparacao = alturaComparacao; indexAltura < menor.Altura; indexAltura++, indexAlturaComparacao++)
                {
                    if (menor.pixels[indexLargura, indexAltura].Red != maior.pixels[indexLarguraComparacao, indexAlturaComparacao].Red)
                    {
                        igualdade = false;
                        break;
                    }
                        
                    else if (menor.pixels[indexLargura, indexAltura].Green != maior.pixels[indexLarguraComparacao, indexAlturaComparacao].Green)
                    {
                        igualdade = false;
                        break;
                    }
                    else if (menor.pixels[indexLargura, indexAltura].Blue != maior.pixels[indexLarguraComparacao, indexAlturaComparacao].Blue)
                    {
                        igualdade = false;
                        break;
                    }
                }
            if (igualdade == true)
                return true;
            larguraComparacao++;
            alturaComparacao++;
        }
        return false;
    }




}
