using Teorema;

double catetoA;
string catetoAString;
double catetoB;
string catetoBString;
double hipotenusa;
Console.WriteLine("Ingrese el cateto A:");
catetoAString = Console.ReadLine();
double.TryParse(catetoAString,out catetoA);
Console.WriteLine("Ingrese el cateto B:");
catetoBString = Console.ReadLine();
double.TryParse(catetoBString,out catetoB);
hipotenusa = Pitagoras.HallarHipotenusa(catetoA,catetoB);
Console.WriteLine($"La hipotenusa es {hipotenusa}");