using System;

class Veiculo
{
    private string placa;
    private string modelo;
    private int horaEntrada;
    private bool estacionado;

    private static int totalVeiculos = 0;

    public Veiculo(string placa, string modelo, int horaEntrada)
    {
        this.placa = placa;
        this.modelo = modelo;
        this.horaEntrada = horaEntrada;
        this.estacionado = true;
        totalVeiculos++;
    }


    public string getPlaca()
    {
        return placa;
    }

    public string getModelo()
    {
        return modelo;
    }

    public int getHoraEntrada()
    {
        return horaEntrada;
    }

    public bool getStatus()
    {
        return estacionado;
    }

 
    public void setModelo(string modelo)
    {
        this.modelo = modelo;
    }

    public void setHoraEntrada(int horaEntrada)
    {
        this.horaEntrada = horaEntrada;
    }

   
    public void registrarSaida()
    {
        estacionado = false;
    }

 
    public void mostrarDados()
    {
        Console.WriteLine($"Placa: {placa}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Hora Entrada: {horaEntrada}");
        Console.WriteLine($"Estacionado: {estacionado}");
        Console.WriteLine("------------------------");
    }

   
    public static int getTotalVeiculos()
    {
        return totalVeiculos;
    }
}

class Program
{
    static void Main()
    {
        Veiculo v1 = new Veiculo("ABC1234", "Gol", 10);
        Veiculo v2 = new Veiculo("DEF5678", "Onix", 11);
        Veiculo v3 = new Veiculo("GHI9012", "HB20", 12);


        v1.mostrarDados();
        v2.mostrarDados();
        v3.mostrarDados();

      
        v2.registrarSaida();

        Console.WriteLine("Após saída:\n");

        v1.mostrarDados();
        v2.mostrarDados();
        v3.mostrarDados();

       
        Console.WriteLine("Total de veículos cadastrados: " + Veiculo.getTotalVeiculos());
    }
}