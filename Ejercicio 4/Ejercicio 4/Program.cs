
using System.Timers;

int n;

Console.Write("Escriba el numero: ");
n = int.Parse(Console.ReadLine());

if (n % 5 == 0)
{
    Console.WriteLine("El numero es multiplo de 5");
}
else
{
    Console.WriteLine("El numero no es multiplo de 5");
}