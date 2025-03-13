

double peso, altura, imc;

Console.Write("Digite su peso (Kg): ");
peso = double.Parse(Console.ReadLine());

Console.Write("Digite su altura (metros): ");
altura = double.Parse(Console.ReadLine());

if (peso <= 0 || altura <= 0)
{
    Console.WriteLine("ERROR: El peso y la altura deben ser mayores que 0.");
}
else
{
    imc = peso / (altura * altura);
    Console.WriteLine($"Su IMC es: {imc:F2}");

    if (imc < 18.5)
    {
        Console.WriteLine("Clasificación: Bajo peso");
    }
    else if (imc < 25)
    {
        Console.WriteLine("Clasificación: Normal");
    }
    else if (imc < 30)
    {
        Console.WriteLine("Clasificación: Sobrepeso");
    }
    else
    {
        Console.WriteLine("Clasificación: Obesidad");
    }
}
