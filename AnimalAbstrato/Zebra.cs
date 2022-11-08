using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstrato
{
    internal class Zebra : Animal
    {
        public Zebra(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public override void emiteSom()
        {
            Console.WriteLine("A zebrinha está falando!");
        }
    }
}
