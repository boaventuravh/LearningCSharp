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

	// o método abaixo é referente ao item  xi
	public void EquivalenteCinza(Rgb cor, Rgb equivalenteCinza)
	{
		double dobRed, dobGreen, dobBlue;
		dobRed = cor.red;
		dobGreen = cor.green;
		dobBlue = cor.blue;
		double luminosidade = Math.Truncate(dobRed * 0.3 + dobGreen * 0.59 + dobBlue * 0.11);
		equivalenteCinza.red = (int)luminosidade; //MathTruncate
		equivalenteCinza.green = (int)luminosidade;
		equivalenteCinza.blue = (int)luminosidade;
	}

	// os dois métodos abaixo são referentes ao item xii, duas formas diferentes de reslver o problema
	public string RepreHexa(Rgb cor)
	{
		int res, quo;

		string redDig1, redDig2;
		quo = cor.red / 16;
		res = cor.red % 16;
		switch (quo)
		{
			case 10: redDig1 = "A"; break;
			case 11: redDig1 = "B"; break;
			case 12: redDig1 = "C"; break;
			case 13: redDig1 = "D"; break;
			case 14: redDig1 = "E"; break;
			case 15: redDig1 = "F"; break;
			default: redDig1 = quo.ToString(); break;
		}
		switch (res)
		{
			case 10: redDig2 = "A"; break;
			case 11: redDig2 = "B"; break;
			case 12: redDig2 = "C"; break;
			case 13: redDig2 = "D"; break;
			case 14: redDig2 = "E"; break;
			case 15: redDig2 = "F"; break;
			default: redDig2 = res.ToString(); break;
		}

		string greenDig1, greenDig2;
		quo = cor.green / 16;
		res = cor.green % 16;
		switch (quo)
		{
			case 10: greenDig1 = "A"; break;
			case 11: greenDig1 = "B"; break;
			case 12: greenDig1 = "C"; break;
			case 13: greenDig1 = "D"; break;
			case 14: greenDig1 = "E"; break;
			case 15: greenDig1 = "F"; break;
			default: greenDig1 = quo.ToString(); break;
		}
		switch (res)
		{
			case 10: greenDig2 = "A"; break;
			case 11: greenDig2 = "B"; break;
			case 12: greenDig2 = "C"; break;
			case 13: greenDig2 = "D"; break;
			case 14: greenDig2 = "E"; break;
			case 15: greenDig2 = "F"; break;
			default: greenDig2 = res.ToString(); break;
		}

		string blueDig1, blueDig2;
		quo = cor.blue / 16;
		res = cor.blue % 16;
		switch (quo)
		{
			case 10: blueDig1 = "A"; break;
			case 11: blueDig1 = "B"; break;
			case 12: blueDig1 = "C"; break;
			case 13: blueDig1 = "D"; break;
			case 14: blueDig1 = "E"; break;
			case 15: blueDig1 = "F"; break;
			default: blueDig1 = quo.ToString(); break;
		}
		switch (res)
		{
			case 10: blueDig2 = "A"; break;
			case 11: blueDig2 = "B"; break;
			case 12: blueDig2 = "C"; break;
			case 13: blueDig2 = "D"; break;
			case 14: blueDig2 = "E"; break;
			case 15: blueDig2 = "F"; break;
			default: blueDig2 = res.ToString(); break;
		}

		string repHexa = "#" + redDig1 + redDig2 + greenDig1 + greenDig2 + blueDig1 + blueDig2;
		return repHexa;
	}

	public string RepreHexaDois(Rgb cor)
	{
		string redDig1, redDig2;
		redDig1 = (cor.red / 16).ToString();
		Convert.ToString(Convert.ToInt32(redDig1, 10), 16);
		switch (redDig1)
		{
			case "10": redDig1 = "A"; break;
			case "11": redDig1 = "B"; break;
			case "12": redDig1 = "C"; break;
			case "13": redDig1 = "D"; break;
			case "14": redDig1 = "E"; break;
			case "15": redDig1 = "F"; break;
		}
		redDig2 = (cor.red % 16).ToString();
		Convert.ToString(Convert.ToInt32(redDig2, 10), 16);
		switch (redDig2)
		{
			case "10": redDig2 = "A"; break;
			case "11": redDig2 = "B"; break;
			case "12": redDig2 = "C"; break;
			case "13": redDig2 = "D"; break;
			case "14": redDig2 = "E"; break;
			case "15": redDig2 = "F"; break;
		}

		string greenDig1, greenDig2;
		greenDig1 = (cor.green / 16).ToString();
		Convert.ToString(Convert.ToInt32(greenDig1, 10), 16);
		switch (greenDig1)
		{
			case "10": greenDig1 = "A"; break;
			case "11": greenDig1 = "B"; break;
			case "12": greenDig1 = "C"; break;
			case "13": greenDig1 = "D"; break;
			case "14": greenDig1 = "E"; break;
			case "15": greenDig1 = "F"; break;
		}
		greenDig2 = (cor.green % 16).ToString();
		Convert.ToString(Convert.ToInt32(greenDig2, 10), 16);
		switch (greenDig2)
		{
			case "10": greenDig2 = "A"; break;
			case "11": greenDig2 = "B"; break;
			case "12": greenDig2 = "C"; break;
			case "13": greenDig2 = "D"; break;
			case "14": greenDig2 = "E"; break;
			case "15": greenDig2 = "F"; break;
		}

		string blueDig1, blueDig2;
		blueDig1 = (cor.blue / 16).ToString();
		Convert.ToString(Convert.ToInt32(blueDig1, 10), 16);
		switch (blueDig1)
		{
			case "10": blueDig1 = "A"; break;
			case "11": blueDig1 = "B"; break;
			case "12": blueDig1 = "C"; break;
			case "13": blueDig1 = "D"; break;
			case "14": blueDig1 = "E"; break;
			case "15": blueDig1 = "F"; break;
		}
		blueDig2 = (cor.blue % 16).ToString();
		Convert.ToString(Convert.ToInt32(blueDig2, 10), 16);
		switch (blueDig2)
		{
			case "10": blueDig2 = "A"; break;
			case "11": blueDig2 = "B"; break;
			case "12": blueDig2 = "C"; break;
			case "13": blueDig2 = "D"; break;
			case "14": blueDig2 = "E"; break;
			case "15": blueDig2 = "F"; break;
		}

		string repHexa = "#" + redDig1 + redDig2 + greenDig1 + greenDig2 + blueDig1 + blueDig2;
		return repHexa;
	}

	//o método abaixo é referente ao item xiii 
	public void Clarear(Rgb cor, double perc)
	{
		double dobRed, dobGreen, dobBlue;
		dobRed = cor.red + cor.red * perc;
		dobGreen = cor.green + cor.green * perc;
		dobBlue = cor.blue + cor.blue * perc;
		cor.red = (int)dobRed;
		cor.green = (int)dobGreen;
		cor.blue = (int)dobBlue;
	}

	//o método abaixo é referente ao item xiv
	public void Escurecer(Rgb cor, double perc)
	{
		double dobRed, dobGreen, dobBlue;
		dobRed = cor.red - cor.red * perc;
		dobGreen = cor.green - cor.green * perc;
		dobBlue = cor.blue - cor.blue * perc;
		cor.red = (int)dobRed;
		cor.green = (int)dobGreen;
		cor.blue = (int)dobBlue;
	}

	//o método abaixo é referente ao item xv
	public Rgb Instanciar(Rgb cor)
	{
		Rgb corNova = new Rgb();
		corNova.red = cor.red;
		corNova.green = cor.green;
		corNova.blue = cor.blue;
		return corNova;
	}

	//os atributos abaixo são refentes ao item xvi
	public int[] preta = new int[3];
	Rgb.preta[0] = 0; // como trabalhar com arrays aqui?

}