using System;
using System.Collections.Generic;
using System.Text;

namespace Herancaa
{
        public class Gerente : Funcionario

        {

            public override double CalcularBonusAnual()

            {

                return (Salario * 0.15) + 1000;

            }

        }

    }
}
