using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace testeEPAAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool variavel = true;

            while (variavel == true) 
            {
                Console.WriteLine("Digite um numero:");
                    
                int num1_int = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite outro numero:");
   
                int num2_int = int.Parse(Console.ReadLine());

                int soma = num1_int + num2_int;

                Console.WriteLine("A soma dos dois números é:" + soma);

                Console.WriteLine("Deseja continuar? (S/N):  ");
                string resp = Console.ReadLine();

                if (resp == "n" || resp == "N")
                {
                    variavel = false;
                }
            }
        }
    }
}
