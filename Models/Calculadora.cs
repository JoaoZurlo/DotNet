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
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round (seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round (coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round (tangente, 4)}");
        }
    }
}