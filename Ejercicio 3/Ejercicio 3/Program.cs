
int edad;

Console.Write("Digite su Edad: ");
edad = int.Parse(Console.ReadLine());

if(edad > 18)
{
    Console.WriteLine("Usted es MAYOR de edad");
}else
{
    Console.WriteLine("Usted es MENOR de edad");
}