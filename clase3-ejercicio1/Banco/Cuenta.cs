namespace Banco
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular,decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string getTitular()
        {
            return this.titular;
        }

        public decimal getCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"El titular es {this.titular} y el monto es {this.cantidad}";
        }

        public void Ingresar(decimal value)
        {
            if(value>0)
            {
                this.cantidad = this.cantidad + value;
            }
        }

        public decimal Retirar(decimal value)
        {
            if(this.cantidad - value > -20000)
            {
                this.cantidad = this.cantidad - value;
            }
            return this.cantidad;
        }


    }
}