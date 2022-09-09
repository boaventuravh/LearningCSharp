using System;
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;
        
    public bool Saque(double decre)
        {
        Console.WriteLine("Realizando um saque de " + decre);
        if (saldo >= decre)
        {
            this.saldo -= decre;
            return true;
        }
        return false; // O else não é necessário nesse caso porque a execução do método é encerrada assim que um return é executado
        
        }

    public void Deposito(double valor)
        {
            this.saldo += valor;
        }
    }