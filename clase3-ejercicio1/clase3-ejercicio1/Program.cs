using Banco;
Cuenta titular1 = new Cuenta("Agustin", 30000);
int opcion;
string opcionString;

decimal monto;
string montoString;

do
{
    Console.WriteLine("Que desea hacer?");
    Console.WriteLine("1.Ingresar monto");
    Console.WriteLine("2.Retirar monto");
    Console.WriteLine("3.Mostrar Monto");
    Console.WriteLine("4.Mostrar todos los datos");
    opcionString = Console.ReadLine();
    int.TryParse(opcionString,out opcion);
    switch(opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el monto a ingresar:");
            montoString = Console.ReadLine();
            decimal.TryParse(montoString,out monto);
            titular1.Ingresar(monto);
            break;
        case 2:
            Console.WriteLine("Ingrese el monto a retirar:");
            montoString = Console.ReadLine();
            decimal.TryParse(montoString,out monto);
            titular1.Retirar(monto);
            break;
        case 3:
            Console.WriteLine($"El monto es: {titular1.getCantidad()}");
            break;
        case 4:
            Console.WriteLine($"{titular1.Mostrar()}");
            break;
    }
}
while (true);