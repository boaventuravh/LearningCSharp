using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003EncapsulamentoModificadoresDeAcesso
{
    class Program
    {
        static void Main()
        {
            
            Conta c = new Conta();

           // não é uma boa prática atribuir valor de forma direta, como acontece abaixo 
           // c.Saldo = 688.96;

            // o mais adequado é fazer da seguinte forma
            c.setSaldo(688.96);

            Console.WriteLine("Saldo: " + c.Saldo);

            c.Numero = 2323;
            Console.WriteLine("Numero: " + c.Numero);

            c.Titular = "Jose de Alencar";
            Console.WriteLine("Titular: " + c.Titular);

            
        }
    }
}
