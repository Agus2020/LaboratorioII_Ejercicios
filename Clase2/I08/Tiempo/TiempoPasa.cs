namespace Tiempo
{
    public class TiempoPasa
    {
        static public void Tiempo(int dia,int mes,int anio)
        {

            DateTime TiempoActual = new DateTime(2022, 03, 28);
            DateTime Nacimiento = new DateTime(anio,mes,dia);
            int diaActual = TiempoActual.Day;
            int mesActual = TiempoActual.Day;
            int anioActual = TiempoActual.Year;
            int diaNacimiento = Nacimiento.Day;
            int mesNacimiento = Nacimiento.Month;
            int anioNacimiento = Nacimiento.Year;
            int diaTotal;
            int mesTotal;
            int anioTotal;
            if(diaActual>diaNacimiento)
            {
                diaTotal = diaActual - diaNacimiento;
            }
            else
            {
                diaTotal = diaNacimiento - diaActual;
            }
            if(mesActual>mesNacimiento)
            {
                mesTotal = mesActual - mesNacimiento;
            }
            else
            {
                mesTotal = mesNacimiento - mesActual;
            }
            if(anioActual>anioNacimiento)
            {
                anioTotal = anioActual - anioNacimiento;
            }
            else
            {
                anioTotal = anioNacimiento - anioActual;
            }
            Console.WriteLine($"Paso {anioTotal} anios, {mesTotal} meses y {diaTotal} dias");
        }
    }
}