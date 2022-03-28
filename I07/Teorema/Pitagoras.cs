namespace Teorema
{
    public class Pitagoras
    {
        static public double HallarHipotenusa(double catetoA, double catetoB)
        {
            double raizCatetoA;
            double raizCatetoB;
            raizCatetoA = Math.Pow(catetoA,2);
            raizCatetoB = Math.Pow(catetoB,2);
            return raizCatetoA + raizCatetoB;
        }
    }
}