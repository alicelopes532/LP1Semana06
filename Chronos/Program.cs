using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch crono1 = new Stopwatch();
        Stopwatch crono2 = new Stopwatch();

        crono1.Start();

        Thread.Sleep(500);

        crono2.Start();

        Thread.Sleep(250);

        crono1.Stop();
        crono2.Stop();

        Console.WriteLine($"Tempo decorrido em crono1: {crono1.Elapsed.TotalSeconds:F4} segundos");
        Console.WriteLine($"Tempo decorrido em crono2: {crono2.Elapsed.TotalSeconds:F4} segundos");
    }
}