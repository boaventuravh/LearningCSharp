using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Conta
    {
        private double saldo;
        public double Saldo
        {
            get // leitura
            {
                return this.saldo;
            }
            set // escrita
            {
                this.saldo = value;
            }
        }
        
    public void setSaldo(double saldoInformado) // boa prática, utilizar métodos para leitura de dados
    {
        this.saldo = saldoInformado;
    }
        private int numero;
        
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        private string titular;
        public string Titular { get; set; }

    
}
