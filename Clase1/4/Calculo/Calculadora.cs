namespace Calculo
{
    public class Calculadora
    {
        public static float Calcular (int primerValor,int segundoValor,int operacion)
        {
            float resultado=2f;
            bool resultadoValidar;
            switch(operacion)
            {
                case 0:
                    resultado =(float) primerValor + segundoValor;
                    break;
                case 1:
                    resultado =(float) primerValor - segundoValor;
                    break;
                case 2:
                    resultado =(float) primerValor * segundoValor;
                    break;
                case 3:
                    resultadoValidar=Validar(segundoValor);
                    if(resultadoValidar == true)
                    {
                        resultado =(float) primerValor / segundoValor;
                    }
                    else
                    {
                        Console.WriteLine("Se ingreso un 0 en el segundo valor");
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(int segundoValor)
        {
            bool resultado = false;
            if (segundoValor != 0)
            {
                resultado = true;
            }
            return resultado;
        }

    }

}