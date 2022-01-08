using System;

namespace dio_poo_herois.Entities
{
    class Mago : Heroi
    {
        public Mago(string nome, string classeFastastica) : base(nome, classeFastastica)
        {
            Nome = nome;
            ClasseFantastica = classeFastastica;
            Nivel = 1;
            PontosDeVida = 50;
            PontosDeMagia = 50;
        }

        public new string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = Nivel + dado.Next(1, 10);
            ValorUltimoAtaque = forcaDoAtaque;
            return Nome + " ataca com seu cajado de magia " + forcaDoAtaque + " de dano.";
        }

        public string Atacar(int bonus)
        {
            Random dado = new Random();
            int forcaDoAtaque = Nivel + dado.Next(1, 10) + bonus;
            ValorUltimoAtaque = forcaDoAtaque;
            return Nome + " ataca com bônus com seu cajado e da " + forcaDoAtaque + " de dano";
        }

    }
}
