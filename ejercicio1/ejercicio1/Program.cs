using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool resultado;
            string numeroString;
            int numero;
            int min=0;
            int max=0;
            int acumulador=0;
            float prom=0;
            for (int i=0;i<10;i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero:");
                    numeroString = Console.ReadLine();
                    resultado = int.TryParse(numeroString, out numero);
                } 
                while (Negocio.Validar.Validador(numero,-100,100)==false);
                if(i==0)
                {
                    min = numero;
                    max = numero;
                    acumulador = numero;
                }
                else
                {
                    if(numero<min)
                    {
                        min = numero;
                    }
                    if(numero>max)
                    {
                        max = numero;
                    }
                    acumulador = acumulador + numero;
                }
            }
            prom = acumulador / 10;
            Console.WriteLine($"El numero maximo es {min}, el numero minimo es {max} y el promedio es {prom}");
        }
    }
}