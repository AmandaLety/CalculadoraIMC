using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC.Models.IMC
{
    internal class IMC : IIMC
    {
        public IMC()
        {
        }

        public IMC(string name, int age, double height, double width)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = width;
        }

        public string name { get; set; }
        public int age { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public double CalculateImc(double weight, double height)
        {
            return weight / (height * height);
        }

    }
}
