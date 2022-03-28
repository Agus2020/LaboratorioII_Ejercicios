int valor;
string valorString;
bool resultado;
int total;
Console.WriteLine("Ingrese el numero a factorizar:");
valorString = Console.ReadLine();
resultado = int.TryParse(valorString,out valor);
total=Calculadora.Calcular.Factorizar(valor);
Console.WriteLine($"El resultado es {total}");