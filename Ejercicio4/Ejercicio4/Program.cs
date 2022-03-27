int primerNumero;
int segundoNumero;
string primerNumeroTexto;
string segundoNumeroTexto;
bool resultadoPrimerNumero;
bool resultadoSegundoNumero;
int opcion=0;
string opcionTexto;
bool resultadoOpcion;
int operacion;
string operacionTexto;
bool resultadoOperacion;
float resultado=0F;
do
{
    Console.WriteLine("Ingrese el primer numero:");
    primerNumeroTexto = Console.ReadLine();
    resultadoPrimerNumero = int.TryParse(primerNumeroTexto,out primerNumero);
    Console.WriteLine("Ingrese el segundo numero:");
    segundoNumeroTexto = Console.ReadLine();
    resultadoSegundoNumero = int.TryParse(segundoNumeroTexto, out segundoNumero);
    Console.WriteLine("Ingrese que operacion desea realizar: 0:Suma, 1:Resta, 2:Multiplicacion, 3:Division");
    operacionTexto = Console.ReadLine();
    resultadoOperacion = int.TryParse(operacionTexto,out operacion);
    resultado = Calculo.Calculadora.Calcular(primerNumero,segundoNumero,operacion);
    Console.WriteLine($"La operacion es {resultado}");
    Console.WriteLine("Desea continuar? 1.Si, 2.No");
    opcionTexto = Console.ReadLine();
    resultadoOpcion = int.TryParse(opcionTexto,out opcion);

}
while (opcion==1);