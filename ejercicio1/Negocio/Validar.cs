namespace Negocio
{
    public class Validar
    {
        static public bool Validador(int valor,int min,int max)
        {
            bool condicion;
            condicion = false;
            if(valor>=min && valor<=max)
            {
                condicion = true;
            }
            return condicion;
        }
    }
} 