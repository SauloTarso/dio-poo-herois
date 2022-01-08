using System;

namespace dio_poo_herois.Entities
{
    class Heroi
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int PontosDeVida { get; set; }
        public int PontosDeMagia { get; set; }
        public string ClasseFantastica { get; set; }
        public string NomeDoPet { get; set; }
        public int FatorProcurado { get; set; }
        public int ValorUltimoAtaque { get; set; }

        public Heroi(string nome, string classeFastastica)
        {
            Nome = nome;
            ClasseFantastica = classeFastastica;
            Nivel = 1;
            PontosDeVida = 50;
            PontosDeMagia = 50;
        }

        public override string ToString()
        {
            return "Meu nome é " + Nome + "\n"
            + "Nivel: " + Nivel + "\n"
            + "Classe: " + ClasseFantastica + "\n"
            + "Ponto de vida: " + PontosDeVida + "\n"
            + "Ponto de magia: " + PontosDeMagia + "\n";
        }
        public string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = Nivel + dado.Next(9, 20);
            ValorUltimoAtaque = forcaDoAtaque;
            return Nome + " ataca com sua espada e da " + forcaDoAtaque + " de dano.";
        }

        public void ReceberDano(int danoRecebido)
        {
            PontosDeVida = PontosDeVida - danoRecebido;
        }

    }
}
