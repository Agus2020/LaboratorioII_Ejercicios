using Tiempo;
int dia;
string diaString;
int mes;
string mesString;
int anio;
string anioString;

Console.WriteLine("Ingrese el dia:");
diaString = Console.ReadLine();
int.TryParse(diaString,out dia);
Console.WriteLine("Ingrese el mes:");
mesString = Console.ReadLine();
int.TryParse(mesString,out mes);
Console.WriteLine("Ingrese el anio:");
anioString = Console.ReadLine();
int.TryParse(anioString,out anio);
TiempoPasa.Tiempo(dia,mes,anio);