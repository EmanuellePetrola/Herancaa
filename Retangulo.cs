using System;
using System.Collections.Generic;
using System.Text;

namespace Herancaa
{
    public class Retangulo : FormaGeometrica
        {

            public double Largura { get; set; }

            public double Altura { get; set; }


            public override double CalcularArea()

            {

                return Largura * Altura;

            }

        }


    }

