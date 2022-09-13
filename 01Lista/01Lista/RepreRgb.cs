using System;

public class Rgb //essa classe como um todo é o item i da lista
{

	public int red, green, blue;


	/*public RepreRgb() { }

	public RepreRgb(double red, double green, double blue)
    {
		this.red = red;
		this.green = green;
		this.blue = blue;
    }
	o que está acontecendo nos 2 "public RepreRgb()" acima? Construtores? */

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
	// os três métodos acima são o número iii da lista
	public double CalcularLuminosidade(double red, double green, double blue)
    {
		double luminosidade = Math.Truncate((red * 0.3) + (green * 0.59) + (blue * 0.11));
		return luminosidade;
    }
	



	



}