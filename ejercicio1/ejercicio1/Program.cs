using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool resultado;
            
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