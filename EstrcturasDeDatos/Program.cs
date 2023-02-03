using System.Collections;
using System.Diagnostics;

// ArrayList numeros = new ArrayList { 4, -3, 5, -2, 1, 2, 6, -2 };
Random rnd = new Random();
ArrayList numeros= new ArrayList();
//Variables
int SumaActual = 0;
int MaximaSuma = 0;
int n = 0;
int m = 0;
int o = 0;
ArrayList randomListNumber(int cantidad){

    for(int num = 0 ; num < cantidad; num++){
        numeros.Add(rnd.Next(cantidad));
    }
    return numeros;
}
int cantidad = randomListNumber(5000).Count;
Stopwatch sw = new Stopwatch();


//Primer Algoritmo
sw.Start();
for (n = 0; n < cantidad; n++)
{
    for (m = 0; m < cantidad; m++)
    {
        SumaActual = 0;
        for (o = n; o <= m; o++)
        {
            SumaActual += (int)numeros[o];
            if (SumaActual > MaximaSuma)
            {
                MaximaSuma = SumaActual;
            }

        }
    }
}
sw.Stop();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Algoritmo 1, la suma es {0}", MaximaSuma);
Console.WriteLine("Para {0} tomo {1:N0} milisegundos", cantidad, sw.ElapsedTicks);
sw.Reset();

// Algoritmo 2

sw.Start();
for (n = 0; n < cantidad; n++)
{
    SumaActual = 0;
    for (m = n; m < cantidad; m++)
    {
        SumaActual += (int)numeros[m];
        if (SumaActual > MaximaSuma)
        {
            MaximaSuma = SumaActual;
        }
    }
}
sw.Stop();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Algoritmo 2, la suma es {0}", MaximaSuma);
Console.WriteLine("Para {0} tomo {1:N0} milisegundos", cantidad, sw.ElapsedTicks);

// Algoritmo 3

sw.Start();
for (m = 0; m < cantidad; m++)
{
    SumaActual += (int)numeros[m];
    if (SumaActual > MaximaSuma)
    {
        MaximaSuma = SumaActual;
    }
    else if (SumaActual < 0)
    {
        SumaActual = 0;
    }
}
sw.Stop();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Algoritmo 3, la suma es {0}", MaximaSuma);
Console.WriteLine("Para {0} tomo {1:N0} milisegundos" , cantidad, sw.ElapsedTicks);