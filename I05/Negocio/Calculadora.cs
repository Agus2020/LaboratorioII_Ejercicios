namespace Negocio
    
{
    using System;
    using System.Text;
    public class Calculadora
    {

        static public string Tabla(int valor)
        {
            string textoInterpolado="a";
            StringBuilder stringBuilder;
            stringBuilder = new StringBuilder();
            for(int i=1;i<10;i++)
            {
                stringBuilder.AppendLine($"{valor} X {i} = {valor*i}");
            }
            Console.WriteLine(stringBuilder.ToString());
            return textoInterpolado;
        }
    }
}