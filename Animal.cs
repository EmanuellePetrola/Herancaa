using System;
using System.Collections.Generic;
using System.Text;

namespace Herancaa
{
    public class Animal
    {
        public string Nome { get; set; }
        public void comer()
        {
            Console.WriteLine($"{Nome} está comendo.");

        }
    }

}
