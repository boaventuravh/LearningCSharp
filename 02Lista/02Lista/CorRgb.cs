using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Lista
{
    public class CorRgb
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }


        public CorRgb(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        // cor Branca

        public static CorRgb CorBranca()
        {
            return new CorRgb(255, 255, 255);
        }
    }
}
