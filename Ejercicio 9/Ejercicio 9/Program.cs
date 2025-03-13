
int n1, n2;

Console.Write("Escriba el primer numero: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Escriba el segundo numero: ");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"El mayor de los numeros es {n1}");
}else
{
    Console.WriteLine($"El mayor de los numeros es {n2}");
}