using System;

class Conta
{
    private double saldo;

    public double Saldo
    {
        get { return saldo; }
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }
}