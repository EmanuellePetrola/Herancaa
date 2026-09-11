using System;
using System.Collections.Generic;
using System.Text;

namespace Herancaa
{
        class Mago : Personagem
        {
            public int PontosDeMagia { get; set; }

            public Mago(string nome, int pontosDeVida, int forcaDeAtaque, int pontosDeMagia)
                : base(nome, pontosDeVida, forcaDeAtaque)
            {
                PontosDeMagia = pontosDeMagia;
            }

            public override void Atacar(Personagem alvo)
            {
                int dano = ForcaDeAtaque;

                alvo.PontosDeVida -= dano;

                if (alvo.PontosDeVida < 0)
                {
                    alvo.PontosDeVida = 0;
                }

                int recuperacao = (int)(dano * 0.1);
                PontosDeMagia += recuperacao;

                Console.WriteLine($"{Nome} causou {dano} de dano em {alvo.Nome}.");
                Console.WriteLine($"{alvo.Nome} ficou com {alvo.PontosDeVida} PV.");
                Console.WriteLine($"{Nome} recuperou {recuperacao} MP.");
            }
        }
    }

