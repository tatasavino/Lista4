using System;
public class Circulo : Object
{
    double raio;

    public Circulo (double raio) 
    {
        this.raio = raio;
    }

    public double GetRaio () 
    {
        return this.raio;
    }

    public void SetRaio (double r) 
    {
      
        Console.Write("\n\n\tInforme o raio: ");
        r = Double.Parse(Console.ReadLine());

        if (r > 0) {
            this.raio = r;
            Console.Write("\n\tRaio armazenado.");
        } else if (r < 0) {
            Console.Write("\n\tNão é possível que um círculo tenha raio negativo. Tente novamente.");
        } else {
            Console.Write("\n\tNão é possível que um círculo tenha raio nulo. Tente novamente.");
        }
        
        
    }

    public double GetCircunferencia () 
    {
        double circunferencia = ((Math.Round(Math.PI,2))*(2*this.raio));
        return (circunferencia);
    }
    public double GetArea () 
    {
        double area = ((Math.Round(Math.PI,2))*(this.raio*this.raio));
        return (area);
    }

    public void GetRelatorio () 
    {
        Console.Write($"\n\n\tRaio: {this.GetRaio()}");
        Console.Write($"\n\tCircunferência: {Math.Round(this.GetCircunferencia(), 2)}");
        Console.Write($"\n\tÁrea: {Math.Round(this.GetArea(), 2)}\n\n");
    }
}