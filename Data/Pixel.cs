using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
   public struct Pixel
    {

        double r;
        double g;
        double b;

        public Pixel (double r, double g, double b)
        {
            this.r = this.g = this.b = 0;
            this.R = r;
            this.G = g;
            this.B = b;
        }
        public double CheckValue(double value)
        {
            if (value >= 0 & value <= 1)
            {
                return value;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static double Trim(double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;
            return value;
        }
        public double R 
        { 
            get
            {
                return r;
            }
            set
            {
                r = CheckValue(value);   
            }
        }

        public double G {
            get
            {
                return g;
            }
            set
            {
                g = CheckValue(value);
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = CheckValue(value);
            }
        }
    }
}
