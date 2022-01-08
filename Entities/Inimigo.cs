using System;

namespace dio_poo_herois.Entities
{
    class Inimigo : Heroi
    {
        public Inimigo(string nome, string classeFastastica) : base(nome, classeFastastica)
        {
            Nome = nome;
            ClasseFantastica = classeFastastica;
            Nivel = 1;
            PontosDeVida = 80;
            PontosDeMagia = 0;
        }

        public new string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = Nivel + dado.Next(1, 15);
            ValorUltimoAtaque = forcaDoAtaque;
            return Nome + " ataca e da " + forcaDoAtaque + " de dano";
        }

    }
}
