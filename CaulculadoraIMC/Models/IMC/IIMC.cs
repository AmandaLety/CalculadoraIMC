using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC.Models.IMC
{
    public interface IIMC
    {
        public string name { get; set; }
        public int age { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public double CalculateImc(double weight, double height);
    }
}
