namespace Escuela
{
    public class Estudiante
    {
        private string apellido;
        private int legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Estudiante(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int value)
        {
            this.notaPrimerParcial = value;
        }

        public void SetNotaSegundoParcial(int value)
        {
            this.notaSegundoParcial = value;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial)/2;
        }

        public float CalcularNotaFinal()
        {
            float promedio=-1;
            if(this.notaPrimerParcial >=4 && this.notaSegundoParcial >=4)
            {
               // promedio = Random.Next(4,11);
            }
            return promedio;
        }

        public 




    }
}