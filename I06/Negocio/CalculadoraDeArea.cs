namespace Negocio
{
    public class CalculadoraDeArea
    {
        static public double CalcularAreaCuadrado(double longitudLado)
        {
            //return Math.Sqrt(longitudLado);
            return Math.Pow(longitudLado,2);
        }
        static public double CalcularAreaTriangulo(double baseT,double alturaT)
        {
            return (baseT * alturaT) / 2;
        }
        static public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio;
        }
    }
}