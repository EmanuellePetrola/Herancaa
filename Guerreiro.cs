using System;
using System.Collections.Generic;
using System.Text;

namespace Herancaa
    {
        class Guerreiro : Personagem
        {
            public int Defesa { get; set; }

            public Guerreiro(string nome, int pontosDeVida, int forcaDeAtaque, int defesa)
                : base(nome, pontosDeVida, forcaDeAtaque)
            {
                Defesa = defesa;
            }

            public override void Atacar(Personagem alvo)
            {
                int dano = (int)(ForcaDeAtaque * 1.2);

                alvo.PontosDeVida -= dano;

                if (alvo.PontosDeVida < 0)
                {
                    alvo.PontosDeVida = 0;
                }

                Console.WriteLine($"{Nome} causou {dano} de dano em {alvo.Nome}.");
                Console.WriteLine($"{alvo.Nome} ficou com {alvo.PontosDeVida} PV.");
            }
        }
    }

