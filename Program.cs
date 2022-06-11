using System;

namespace p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Circulo c1 = new Circulo(3.0);
            c1.GetRelatorio();

            Circulo c2 = new Circulo(3.4);
            c2.GetRelatorio();

            Circulo c3 = new Circulo(8.7);
            c3.GetRelatorio();

            Quadrado q1 = new Quadrado(2.4);
            q1.GetRelatorio();

            Quadrado q2 = new Quadrado(2.4);
            q2.GetRelatorio();

            Quadrado q3 = new Quadrado(2.4);
            q3.GetRelatorio();

        }

    }
}