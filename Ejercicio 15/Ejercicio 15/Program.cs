
int lado1, lado2, lado3;

Console.Write("Digite el primer lado: ");
lado1 = int.Parse(Console.ReadLine());

Console.Write("Digite el segundo lado: ");
lado2 = int.Parse(Console.ReadLine());

Console.Write("Digite el tercer lado: ");
lado3 = int.Parse(Console.ReadLine());

if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
{
    Console.WriteLine("ERROR => Los lados deben ser mayores que 0");
}else if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
{
    Console.WriteLine($"Los lados [{lado1}], [{lado2}] y [{lado3}] pueden formar un triángulo.");
}else
{
    Console.WriteLine($"Los lados [{lado1}], [{lado2}] y [{lado3}] NO pueden formar un triángulo.");
}
