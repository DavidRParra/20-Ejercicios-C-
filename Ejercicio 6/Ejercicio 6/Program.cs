
using System.Timers;

int calificacion;

Console.Write("Escriba la calificacion: ");
calificacion = int.Parse(Console.ReadLine());

if (calificacion >= 60 && calificacion<=100)
{
    Console.WriteLine("El estudiante aprobo");
}
else if(calificacion <= 60 &&  calificacion>=0)
{
    Console.WriteLine("El estudiante NO aprobo");
}
else
{
    Console.WriteLine("La nota ingresada es invalida");
}