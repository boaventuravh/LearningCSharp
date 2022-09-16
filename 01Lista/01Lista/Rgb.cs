using System;
using System.Collections;

public class Rgb //essa classe como um todo é o item i da lista
{

	public int red, green, blue;

	// os três métodos abaixo são o número iii da lista, juntamente com os métodos GetRed, GetGreen e GetBlue
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
	
	// o método abaixo é o item iv da lista de exercícios.  Atende ao item x também?
	public double CalcularLuminosidade(double red, double green, double blue)
    {
		double luminosidade = Math.Truncate((red * 0.3) + (green * 0.59) + (blue * 0.11));
		return luminosidade;
    }

	/*os dois "public Rgb" abaixo são um exemplo de sobrecargas de construtores
	 item v da lista de exercícios*/

	public Rgb() { } // esse construtor atende a solicitação do item vii

	public Rgb(int red, int green, int blue) // esse construtor atende a solicitação do item viii
	{
		this.red = red;
		this.green = green;
		this.blue = blue;
    }

	

	// o construtor abaixo é referente ao item vi
	
	public Rgb(Rgb corOriginal)
	{
		this.red = corOriginal.red;
		this.green = corOriginal.green;
		this.blue = corOriginal.blue;
	}

	// o método abaixo é referente ao item ix 
	public override bool Equals (Rgb cor)
    {
		Rgb cor2 = (Rgb)cor;
    }
	public bool ComparaCores(Rgb cor1, Rgb cor2) 
    {
		if (cor1.red == cor2.red && cor1.green == cor2.green && cor1.blue == cor2.blue)
			return true;
		else
			return false;
    }

	public bool ComparaCoresDiferente(Rgb cor1, Rgb cor2)
	{
		if (cor1.red != cor2.red)
			return false;

		if (cor1.green != cor2.green)
			return false;

		if (cor1.blue != cor2.blue)
			return false;

		return true;
	}

	// as 3 propriedades abaixo são referentes ao item x
	public int GetRed(Rgb cor)
	{
		return cor.red;
	}

	public int GetGreen(Rgb cor)
	{
		return cor.green;
	}

	public int GetBlue(Rgb cor)
	{
		return cor.blue;
	}



}