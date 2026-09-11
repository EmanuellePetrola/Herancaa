using System;
using System.Collections.Generic;
using System.Text;

namespace Herancaa
{
        class Personagem
        {
            public string Nome { get; set; }
            public int PontosDeVida { get; set; }
            public int ForcaDeAtaque { get; set; }

            public Personagem(string nome, int pontosDeVida, int forcaDeAtaque)
            {
                Nome = nome;
                PontosDeVida = pontosDeVida;
                ForcaDeAtaque = forcaDeAtaque;
            }

            public virtual void Atacar(Personagem alvo)
            {
                alvo.PontosDeVida -= ForcaDeAtaque;

                if (alvo.PontosDeVida < 0)
                {
                    alvo.PontosDeVida = 0;
                }

                Console.WriteLine($"{Nome} causou {ForcaDeAtaque} de dano em {alvo.Nome}.");
                Console.WriteLine($"{alvo.Nome} ficou com {alvo.PontosDeVida} PV.");
            }

            public bool EstaVivo()
            {
                return PontosDeVida > 0;
            }
        }
    }

