using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoConsoleCronometro
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Menu());
            Console.WriteLine("Quanto tempo desejar contar? ");

            string dado = Console.ReadLine().ToLower();
            char type = char.Parse(dado.Substring(dado.Length - 1, 1));
            int time = int.Parse(dado.Substring(0, dado.Length - 1));
            int multiplicador = 1;

            if (type == 'm')
                multiplicador = 60;

            if(time == 0)
                System.Environment.Exit(0);


            PreStart(time * multiplicador);
            
            Console.ReadLine();
        }

        static string Menu()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Menu");
            sb.AppendLine("S = segundos => 10s = 10 segundos");
            sb.AppendLine("M = Minutos => 10m = 10 minutos");
            sb.AppendLine("0 = Sair");

            return sb.ToString();
        }

        public static void PreStart(int time)
        {
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(3000);

            StartCronometro(time);
        }

        public static void StartCronometro(int temporizador)
        {
            int TempoAtual = 0;

            while(TempoAtual != temporizador)
            {
                TempoAtual++;
                Console.Clear();
                Console.WriteLine(TempoAtual);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
    }
}
