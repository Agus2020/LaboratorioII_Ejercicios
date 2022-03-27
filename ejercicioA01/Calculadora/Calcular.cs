namespace Calculadora
{
    public class Calcular
    {
        static public int Factorizar (int numeroACalcular)
        {
            int factorial = 1;
            int numFactorial = (int)numeroACalcular;
            if (numFactorial != 0)
            {
                factorial = numFactorial * Factorizar(numFactorial - 1);
            }
            return factorial;
        }

    }
}