using System;
using System.Globalization;

namespace AreaDoCirculo
{
    class Program
    {
        
        static void Main(string[] args)

        {
            // Instaciamento da classe e input do usuario
            //      Calculadora calc = new Calculadora();
            Console.Write("Entre com o valor do Raio :");
            double raio = Double.Parse(Console.ReadLine());
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            // Feedback do resultado
            Console.WriteLine("Circunferencia : " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume : " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferencia : " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));  
        }
    }
}
