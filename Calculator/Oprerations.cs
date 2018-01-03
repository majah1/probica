using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Oprerations
    {
        float a;
        float b;
        private float third;

        public Oprerations(float first, float second)
        {
            this.A = first;
            this.B = second;
        }

        public Oprerations(float third)
        {
            this.third = third;
        }

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }

        public float sabiranje()
        {
            return this.A + this.B;
        }

        public float deljenje()
        {
            return this.A / this.B;
        
        }

        public float mnozenje()
        {
            return this.a * this.b;

        }

        public float oduzimanje()
        {
            float c;
                c = this.a - this.b;
            return c;

        }

    }

}
