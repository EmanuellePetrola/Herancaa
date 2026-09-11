using System;
using System.Collections.Generic;
using System.Text;

namespace Herancaa
{
    public class Funcionario
    {
            public string Nome { get; set; }

            public double Salario { get; set; }


            public virtual double CalcularBonusAnual()

            {

                return Salario * 0.10;

            }

        }

    }


