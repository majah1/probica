using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Oprerations
    {
        List<float> array;

        public List<float> Array { get => array; set => array = value; }

        //float b;
        //private float third;

        public Oprerations(List<float> nizbrojeva)
        {
            this.Array = nizbrojeva;
    
        }

    

        public float sabiranje()
        {
            float sum = 0;
            for (int i = 0; i < this.Array.Count; i++)
            {
                sum += this.Array[i]; }

            return sum;
        }

        //public float deljenje()
        //{
        //    return this.A / this.B;
        
        //}

        //public float mnozenje()
        //{
        //    return this.a * this.b;

        //}

        //public float oduzimanje()
        //{
        //    float c;
        //        c = this.a - this.b;
        //    return c;

        //}

    }

}
