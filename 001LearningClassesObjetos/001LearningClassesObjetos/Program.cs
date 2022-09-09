using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001LearningClassesObjetos
{
    class TestandoConta
    {
        static void Main() 
        {
            Conta v = new Conta();
            bool saqueSucedido;
            

            Console.WriteLine("Digite o numero da conta: ");
            v.numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular: ");
            v.titular = Console.ReadLine();
            Console.WriteLine("Digite o saldo inicial: ");
            v.saldo = double.Parse(Console.ReadLine());
            
            Console.WriteLine("----------Dados da conta------------");
            Console.WriteLine("Numero: " + v.numero);
            Console.WriteLine("Titular: " + v.titular);
            Console.WriteLine("Saldo inicial: " + v.saldo);

            Console.WriteLine("Digite o valor do saque: ");
            double valorSacado = double.Parse(Console.ReadLine());

            saqueSucedido = v.Saque(valorSacado);

            if(saqueSucedido)
            {
                Console.WriteLine("Saque bem sucedido!");
                Console.WriteLine("Saldo final: " + v.saldo);
            }
            else
            {
                Console.WriteLine("Nao foi possivel realizar o saque!");
            }

            Console.WriteLine("Qual o valor do deposito?");
            double valorDepositado = double.Parse(Console.ReadLine());
            v.Deposito(valorDepositado);

            Console.WriteLine("Saldo atualizado: " + v.saldo);

        }
    }
}
