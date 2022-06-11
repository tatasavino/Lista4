public class Quadrado : Object 
{
    double lado;
    public Quadrado (double lado) 
    {
        this.lado = lado;
    }

    public double GetLado ()
    {
        return this.lado;
    }
    public void SetLado (double l) 
    {
    
        if (l > 0) {
            this.lado = l;
            Console.Write("\n\tRaio armazenado.");
        } else if (l < 0) {
            Console.Write("\n\tNão é possível que um círculo tenha raio negativo. Tente novamente.");
        } else {
          Console.Write("\n\tNão é possível que um círculo tenha raio nulo. Tente novamente.");
        }

    }
    public double GetPerimetro () 
    {
        double perimetro = (4*lado);
        return (perimetro);
    }
    public double GetArea () 
    {
        double area = (lado*lado);
        return (area);
    }

    public void GetRelatorio () 
    {
        Console.Write($"\n\n\tLado: {this.GetLado()}");
        Console.Write($"\n\tPerímetro: {Math.Round(this.GetPerimetro(), 2)}");
        Console.Write($"\n\tÁrea: {Math.Round(this.GetArea(), 2)}\n\n");
    }
}