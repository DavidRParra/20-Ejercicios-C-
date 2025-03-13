
int lado1, lado2, lado3;

Console.Write("Digite el primer lado: ");
lado1 = int.Parse(Console.ReadLine());

Console.Write("Digite el segundo lado: ");
lado2 = int.Parse(Console.ReadLine());

Console.Write("Digite el tercer lado: ");
lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("El triángulo es Equilátero.");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("El triángulo es Isósceles.");
}
else
{
    Console.WriteLine("El triángulo es Escaleno.");
}
