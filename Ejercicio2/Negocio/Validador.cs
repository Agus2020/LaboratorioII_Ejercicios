namespace Negocio
{
    public class Validador
    {
        static public bool ValidarRespuesta(string opcion)
        {
            bool condicion = false;
            if (opcion != 'S')
            {
                return condicion;
            }
            condicion = true;
            return condicion;

        }
    }
}