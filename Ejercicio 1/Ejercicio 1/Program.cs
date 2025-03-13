
int n;

Console.Write("Escribir el numero: ");

n = int.Parse(Console.ReadLine());

if (n == 0)
{
    Console.WriteLine("Su numero es igual a CERO");
}else if( n > 0)
{
    Console.WriteLine("Su numero es POSITIVO");
}else
{
    Console.WriteLine("Su numero es NEGATIVO");
}