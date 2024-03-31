using System;

namespace Investigação
{
    class Program
    {
        static void Main(string[] args)
        {
            string res1, res2, res3, res4, res5;
            int cont, cont1, cont2, cont3, cont4, cont5;
            Console.Clear();

            Console.WriteLine("*****************Investigação Criminal*******************");
            Console.WriteLine(" ");
            Console.WriteLine("Digite sua Resposta com S ou N");
            Console.WriteLine(" ");
            Console.WriteLine("Telefonou Para a Vitima?");
            res1 = Console.ReadLine();

            cont = 0;

            if (res1 == "S")
            {
                cont1 = cont + 1;
            }
            else
            {
                cont1 = cont + 0;
            }
            Console.Clear();
            Console.WriteLine("Esteve no local do crime?");
            res2 = Console.ReadLine();

            if (res2 == "S")
            {
                cont2 = cont1 + 1;
            }
            else
            {
                cont2 = cont1 + 0;
            }
            Console.Clear();
            Console.WriteLine("Morava perto da vítima?");
            res3 = Console.ReadLine();

            if (res3 == "S")
            {
                cont3 = cont2 + 1;
            }
            else
            {
                cont3 = cont2 + 0;
            }
            Console.Clear();
            Console.WriteLine("Devia para a vítima?");
            res4 = Console.ReadLine();

            if (res4 == "S")
            {
                cont4 = cont3 + 1;
            }
            else
            {
                cont4 = cont3 + 0;
            }
            Console.Clear();
            Console.WriteLine("Já trabalhou com a vítima?");
            res5 = Console.ReadLine();

            if (res5 == "S")
            {
                cont5 = cont4 + 1;
            }
            else
            {
                cont5 = cont4 + 0;
            }

            if (cont5 == 2)
            {
                Console.Clear();
                Console.WriteLine("Suspeito");
            }
            else if (cont5 == 3 || cont5 == 4)
            {
                Console.Clear();
                Console.WriteLine("Cúmplice");
            }

            else if (cont5 == 5)
            {
                Console.Clear();
                Console.WriteLine("Assasino");
            }
        }
    }
}
