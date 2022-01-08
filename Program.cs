using System;
using dio_poo_herois.Entities;

namespace dio_poo_herois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do Heroi: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a classe: ");
            string classe = Console.ReadLine();
            Heroi heroi = new Heroi(nome, classe);
            Console.WriteLine();

            Console.Write("Digite o nome do Heroi: ");
            nome = Console.ReadLine();
            Console.Write("Digite a classe: ");
            classe = Console.ReadLine();
            Mago mago = new Mago(nome, classe);
            Console.WriteLine();

            Console.Write("Digite o nome do Inimigo: ");
            nome = Console.ReadLine();
            Console.Write("Digite a classe: ");
            classe = Console.ReadLine();
            Inimigo inimigo = new Inimigo(nome, classe);
            Console.WriteLine();

            Console.WriteLine(heroi.Atacar());
            Console.WriteLine();
            Console.WriteLine(inimigo.Atacar());
            Console.WriteLine();


            if (heroi.ValorUltimoAtaque == inimigo.ValorUltimoAtaque)
            {
                Console.WriteLine("Empate, ambos deram dano de " + heroi.ValorUltimoAtaque);
            }
            else if (heroi.ValorUltimoAtaque > inimigo.ValorUltimoAtaque)
            {
                inimigo.ReceberDano(heroi.ValorUltimoAtaque - inimigo.ValorUltimoAtaque);
                Console.WriteLine(heroi.Nome + " venceu esse round.");
            }
            else
            {
                heroi.ReceberDano(inimigo.ValorUltimoAtaque - heroi.ValorUltimoAtaque);
                Console.WriteLine(inimigo.Nome + " venceu esse round.");
            }

        }
    }
}
