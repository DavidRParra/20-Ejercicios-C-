
int angulo;

Console.Write("Escriba el valor del angulo: ");
angulo = int.Parse(Console.ReadLine());

if (angulo == 90)
{
    Console.WriteLine("El angulo es Recto");
}else if (angulo == 180) 
{
    Console.WriteLine("El angulo es Llano");
}else if (angulo > 90 && angulo < 180)
{
    Console.WriteLine("El angulo es Obtuso");
}else if (angulo < 90 && angulo > 0)
{
    Console.WriteLine("El angulo es Agudo");
}
else
{
    Console.WriteLine("El angulo introducido es incorrecto");
}