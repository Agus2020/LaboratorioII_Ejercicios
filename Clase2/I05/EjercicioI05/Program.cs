int numero;
string numeroString;
bool resultadoString;
string textoInterpolado;
Console.WriteLine("Ingrese un numero:");
numeroString = Console.ReadLine();
resultadoString = int.TryParse(numeroString,out numero);
textoInterpolado = Negocio.Calculadora.Tabla(numero);