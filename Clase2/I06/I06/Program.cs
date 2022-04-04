using Negocio;
int opcion;
string opcionString;
double respuesta=0;

double longitud;
string longitudString;

double baseT;
string baseTString;
double alturaT;
string alturaTString;

double radio;
string radioString;

Console.WriteLine("Que operacion desea realizar?");
Console.WriteLine("1.Calcular area Cuadrado, 2.Calcular area Triangulo, 3.Calcular area Circulo");
opcionString = Console.ReadLine();
int.TryParse(opcionString,out opcion);
switch(opcion)
{
    case 1:
        Console.WriteLine("Ingrese la longitud del cuadrado:");
        longitudString=Console.ReadLine();
        double.TryParse(longitudString,out longitud);
        respuesta = CalculadoraDeArea.CalcularAreaCuadrado(longitud);
        break;
    case 2:
        Console.WriteLine("Ingrese la base del triangulo:");
        baseTString = Console.ReadLine();
        double.TryParse(baseTString,out baseT);
        Console.WriteLine("Ingrese la altura del triangulo:");
        alturaTString = Console.ReadLine();
        double.TryParse(alturaTString, out alturaT);
        respuesta = CalculadoraDeArea.CalcularAreaTriangulo(baseT,alturaT);
        break;
    case 3:
        Console.WriteLine("Ingrese el radio del circulo:");
        radioString = Console.ReadLine();
        double.TryParse(radioString, out radio);
        respuesta = CalculadoraDeArea.CalcularAreaCirculo(radio);
        break;
}
Console.WriteLine($"El radio es {respuesta}");
