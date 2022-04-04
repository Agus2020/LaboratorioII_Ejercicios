namespace Negocio
{
    public class Boligrafo
    {
        private int color;
        private int tinta;
        private const int cantidadTintaMaxima=100;

        public int GetColor()
        {
            return this.color;
        }

        public int GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(int value)
        {
            if(value>0)
            {
                if((this.tinta + value) <= cantidadTintaMaxima)
                {
                    this.tinta = this.tinta + value;
                }
            }
            else
            {
                if((this.tinta - value) <= 0 )
                {
                    this.tinta = this.tinta - value;
                }
            }
        }

        private void TintaMaxima()
        {
            this.tinta = cantidadTintaMaxima;
        }

        private void TintaGastar()
        {

        }

        public void Recargar()
        {
            TintaMaxima();
        }


      //  public string Pintar(int gasto)

    }
}