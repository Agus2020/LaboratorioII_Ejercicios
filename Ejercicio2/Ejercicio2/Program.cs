string opcion;
int i=0;
int numero=0;
string numeroTexto;
bool resultado;
int acumulador = 0;
do
{
    Console.WriteLine("Ingrese un numero:");
    numeroTexto = Console.ReadLine();
    resultado = int.TryParse(numeroTexto, out numero);
    if(i==0)
    {
        acumulador = numero;
    }
    else
    {
        acumulador = acumulador + numero;
    }
    i++;
    Console.WriteLine($"Acumulador:{acumulador}");
    Console.WriteLine("Desea continuar ?, escriba 'S'");
    opcion = Console.ReadLine();

}while(Negocio.Validador.ValidarRespuesta(opcion)==false);