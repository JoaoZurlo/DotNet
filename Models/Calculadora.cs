using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void subtração(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void multiplicação(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void divisão(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void potencia(int x, int y)
        {
            double pot = Math.Pow(x, y); //classe para realizar a potncia;
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {
            Math.Sin(angulo);
            Console.WriteLine()
        }
    }
}