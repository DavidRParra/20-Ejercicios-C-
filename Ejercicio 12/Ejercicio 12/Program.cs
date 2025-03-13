
int[] n = new int[3];

int pos = 0, neg = 0, cero = 0;
bool mix;

for (int i = 0; i < 3; i++)
{
    Console.Write($"Escriba el numero en la posicion[{i+1}]: ");
    n[i] = int.Parse(Console.ReadLine());

    if ( n[i] == 0)
    {
        cero = cero + 1;
    }else if ( n[i] > 0)
    {
        pos = pos + 1;
    }else if( n[i] < 0)
    {
        neg = neg + 1;
    }
}

mix = (neg > 0 && pos > 0) || (cero > 0 && (neg > 0 || pos > 0));

Console.WriteLine($"Numeros Positivos: {pos}\nNumeros Negativos {neg}\nCantidad de Ceros {cero}\nMixto: {mix}");
