
int n1, n2, n3;

Console.Write("Escribir el Primer numero: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Escribir el Segundo numero: ");
n2 = int.Parse(Console.ReadLine());

Console.Write("Escribir el Tercer numero: ");
n3 = int.Parse(Console.ReadLine());

if(n1 > n2 && n1 > n3)
{
    Console.WriteLine($"El mayor es: {n1}");
}else if(n1 < n2 && n2 > n3)
{
    Console.WriteLine($"El mayor es: {n2}");
}else
{
    Console.WriteLine($"El mayor es: {n3}");

}