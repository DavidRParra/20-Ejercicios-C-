
double precio, descuento;

Console.Write("Digite el precio: ");
precio = int.Parse(Console.ReadLine());

if  (precio < 50)
{
    Console.WriteLine($"El precio es: {precio}");
}else if (precio > 100)
{
    descuento = precio * 0.1;
    Console.WriteLine($"El precio es: {precio - descuento}");
}else
{
    descuento = precio * 0.05;
    Console.WriteLine($"El precio es: {precio - descuento}");
}