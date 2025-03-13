

int year;

Console.Write("Digitar el año a verificar: ");
year = int.Parse(Console.ReadLine());

// Verificación simplificada
if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
{
    Console.WriteLine($"El año {year} SÍ es BISIESTO");
}
else
{
    Console.WriteLine($"El año {year} NO es BISIESTO");
}
