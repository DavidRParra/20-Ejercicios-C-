
int edad;

Console.Write("Escriba la Edad: ");
edad = int.Parse(Console.ReadLine());

if (edad > 60)
{
    Console.WriteLine("Usted aplica a un descuento del 50%");
}
else
{
    Console.WriteLine("Usted no aplica al descuento del 50%");
}