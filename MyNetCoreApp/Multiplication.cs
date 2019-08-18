using System;
using System.Collections.Generic;
using System.Text;

namespace MyNetCoreApp
{
    public class Multiplication : ICalculation
    {
        private readonly decimal x;
        private readonly decimal y;

        public Multiplication(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public decimal Calculate()
        {
            return x * y;
        }
    }
}
