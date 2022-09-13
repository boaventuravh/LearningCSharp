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
            Conta c = new Conta();
            //bool saqueSucedido;
            

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
            
            Console.WriteLine("Digite o numero da conta: ");
            c.numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular: ");
            c.titular = Console.ReadLine();
            Console.WriteLine("Digite o saldo inicial: ");
            c.saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("----------Dados da conta------------");
            Console.WriteLine("Numero: " + c.numero);
            Console.WriteLine("Titular: " + c.titular);
            Console.WriteLine("Saldo inicial: " + c.saldo);

            Console.WriteLine("Digite o valor da transferencia: ");
            double valorTransf = double.Parse(Console.ReadLine());

            c.Trasnf(valorTransf, v);



            

            /* 
              if(saqueSucedido)
            {
                Console.WriteLine("Transferencia bem sucedida!");
                Console.WriteLine("Saldo final: " + v.saldo);
            }
            else
            {
                Console.WriteLine("Nao foi possivel realizar a tranferencia!");
            }

            Console.WriteLine("Qual o valor do deposito?");
            double valorDepositado = double.Parse(Console.ReadLine());
            v.Deposito(valorDepositado);*/

            Console.WriteLine("Saldo atualizado: ");
            Console.WriteLine("Conta c: " + c.saldo);
            Console.WriteLine("Conta v: " + v.saldo);


        }
    }
}
