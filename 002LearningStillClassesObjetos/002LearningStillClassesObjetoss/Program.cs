using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002LearningStillClassesObjetoss
{
    class Program
    {
        static void Main()
        {
            Cliente jose = new Cliente();
            jose.nome = "Jose";

            Conta testConta = new Conta();
            testConta.titular = jose;
            jose.cpf = "005.125.748-22";
            Console.WriteLine(testConta.titular.nome);
            Console.WriteLine(jose.cpf);
        }
    }
}
