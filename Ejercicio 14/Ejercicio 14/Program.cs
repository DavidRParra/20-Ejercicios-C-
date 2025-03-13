
int nota;

Console.Write("Digite la nota: ");
nota = int.Parse(Console.ReadLine());

if (nota < 0 || nota > 100) 
{
    Console.WriteLine($"La nota [{nota}] es igual: ERROR => Debe esta entre 0 y 100");
}
else if (nota >= 90)
{
    Console.WriteLine($"La nota [{nota}] es igual: [A]");
}else if (nota >= 80)
{
    Console.WriteLine($"La nota [{nota}] es igual: [B]");
}else if (nota >= 70)
{
    Console.WriteLine($"La nota [{nota}] es igual: [C]");
}else if (nota >= 60)
{
    Console.WriteLine($"La nota [{nota}] es igual: [D]");
}else
{
    Console.WriteLine($"La nota [{nota}] es igual: [F]");
}