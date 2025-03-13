
int temperatura;

Console.Write("Digite la temperatura: ");
temperatura = int.Parse(Console.ReadLine());

if (temperatura < 0)
{
    Console.WriteLine("Hace mucho frío");
}
else if (temperatura <= 20)
{
    Console.WriteLine("Clima fresco");
}
else if (temperatura <= 30)
{
    Console.WriteLine("Clima agradable");
}
else
{
    Console.WriteLine("Hace mucho calor");
}
