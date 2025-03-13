int hora;

Console.Write("Digite la hora: ");
hora = int.Parse(Console.ReadLine());

if (hora < 0 || hora > 23)
{
    Console.WriteLine("ERROR: La hora debe estar entre 0 y 23.");
}
else if (hora >= 6 && hora <= 11)
{
    Console.WriteLine("Mañana");
}
else if (hora >= 12 && hora <= 17)
{
    Console.WriteLine("Tarde");
}
else if (hora >= 18 && hora <= 23)
{
    Console.WriteLine("Noche");
}
else
{
    Console.WriteLine("Madrugada");
}
