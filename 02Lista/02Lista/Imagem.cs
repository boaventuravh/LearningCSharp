using System;

public class Imagem
{
    //atributos
    public int largura, altura, tamanho;
    public int red, green, blue;
    public int[] rgb = new int[3];

    //métodos
    public void SetLargura (int largura)
    {
        this.largura = largura;
    }
    public void SetAltura(int altura)
    {
        this.altura = altura;
    }
    public void SetRed(int red)
    {
        this.red = red;
    }

    public void SetGreen(int green)
    {
        this.green = green;
    }

    public void SetBlue(int blue)
    {
        this.blue = blue;
    }

    public void SetRgb()
    {
        this.rgb[0] = this.red;
        this.rgb[1] = this.green;
        this.rgb[2] = this.blue;
    }
    public int CalculaTamanho()
    {
        this.tamanho = this.altura * this.largura;
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
    public Imagem(int tamanho) // todos os pixels ajustados para branco
    {
        tamanho = this.tamanho;
        int largura = tamanho / this.altura;
        int altura = tamanho / this.largura;
        int[,,] pixel = new int[altura, largura, this.rgb.Length];
        for (int alt = 0; alt < altura; alt++)
            for (int larg = 0; larg < largura; larg++)
                for (int r = 0; r < this.rgb.Length; r++)
                    this.rgb[r] = 255;   
    }


    
    
}
