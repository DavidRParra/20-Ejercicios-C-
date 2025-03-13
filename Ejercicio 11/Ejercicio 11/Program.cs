

double impuesto, salarioTotal, salario;

Console.Write("Digite el salario del empleado: ");
salario = double.Parse(Console.ReadLine());

if (salario < 10000)
{
    Console.WriteLine($"El salario total del empleado es: {salario}");
}else if (salario <= 30000)
{
    impuesto = salario * 0.1;
    salarioTotal = salario - impuesto;
    Console.WriteLine($"El salario total del empleado es: {salarioTotal}");

}
else
{
    impuesto = salario * 0.2;
    salarioTotal = salario - impuesto;
    Console.WriteLine($"El salario total del empleado es: {salarioTotal}");
}