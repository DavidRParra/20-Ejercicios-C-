

int n;

Console.Write("Escriba el dia de la semana en numero: ");
n = int.Parse(Console.ReadLine());

switch (n)
{
    case 1:
        Console.WriteLine($"El dia correspondiente al numero [{n}] es [Lunes]");
        break;
    case 2:
        Console.WriteLine($"El dia correspondiente al numero [{n}] es [Martes]");
        break;
    case 3:
        Console.WriteLine($"El dia correspondiente al numero [{n}] es [Miercoles]");
        break;
    case 4:
        Console.WriteLine($"El dia correspondiente al numero [{n}] es [Jueves]");
        break;
    case 5:
        Console.WriteLine($"El dia correspondiente al numero [{n}] es [Viernes]");
        break;
    case 6:
        Console.WriteLine($"El dia correspondiente al numero [{n}] es [Sabado]");
        break;
    case 7:
        Console.WriteLine($"El dia correspondiente al numero [{n}] es [Domingo]");
        break;
    default:
        Console.WriteLine($"El dia correspondiente al numero [{n}] NO ES VALIDO");
        break;
}
