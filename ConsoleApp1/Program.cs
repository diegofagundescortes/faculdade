using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 100;
            Console.WriteLine("Forneça um ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite algo sobre o funcionario");
            string info = Console.ReadLine();
            switch(info)
            {
                case "nome":
                    Console.WriteLine("Nome:Joao");
                    break;
                case "salario":
                    Console.WriteLine("Salario R$ " + salario.ToString());
                    break;
            }

            
    }
}
