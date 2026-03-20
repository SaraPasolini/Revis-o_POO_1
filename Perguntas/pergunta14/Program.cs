using System;

class Carro
{
    public string Cor { get; set; }
    public int Ano { get; set; }

    public Carro(string cor, int ano)
    {
        Cor = cor;
        Ano = ano;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Cor: {Cor}, Ano: {Ano}");
    }
}

class Program
{
    static void Main()
    {
       
        Carro carro1 = new Carro("Preto", 2023);
        Carro carro2 = new Carro("Branco", 2022);

        carro1.ExibirDados();
        carro2.ExibirDados();
    }
}