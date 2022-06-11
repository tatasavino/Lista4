using System;
public class Funcionario : Object
{
    string cpf;
    string nome;
    string sobrenome;
    double salario;

    public Funcionario (string cpf, string nome, string sobrenome, double salario)
    {
        this.cpf = cpf;
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.salario = salario;
    }

    public override string ToString () 
    {
        return $"\n\tNome: {this.nome} {this.sobrenome}\n\tCpf: {this.cpf}\n\tSalário: {this.salario}\n";
    }

    public string GetCpf () 
    {
        return this.cpf;
    }
    public string GetNome () 
    {
        return this.nome;
    }
    public string GetSobrenome () 
    {
        return this.sobrenome;
    }
    public double GetSalario () 
    {
        return this.salario;
    }

    public double GetSalarioAnual ()
    {
        return (this.salario*12);
    }

    public void SetSalario (double salario) 
    {
        this.salario = salario;
    }
    public void AumentarSalario (double percentual)
    {
        percentual = (percentual/100);
        this.salario = (this.salario + this.salario*percentual);

    }

}