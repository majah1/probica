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

            public int faktorijal(int broj)
        {
            // broj = 6
            // 2 * 3 * 4 * 5 * 6
            int faktorijel = 1;
            int i = 2;
            while (i<=broj)
               
            {
                faktorijel *= i;
                i++;
            }
            return faktorijel;
        }

        public float oduzimanje()
        {
            float odu = this.Array[0];
            for (int i = 1; i < this.Array.Count; i++)
            {
               //if (i==0) {
               //     //   this.Array[i] = this.Array[i] * -1;
               //     odu = this.Array[i];
               // }
                odu -= this.Array[i];
            }

            return odu;
        }

        public float mnozenje()
        {
            float mno = 1;
            for (int i = 0; i < this.Array.Count; i++)
            {
                mno *= this.Array[i];
            }

            return mno;
        }
    }

}
