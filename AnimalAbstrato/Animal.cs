using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstrato
{
     abstract class Animal
    {
        public string nome;
        public string sexo;
        public string raca;
        public Animal(string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }

        public abstract void emiteSom();

        public void caminhar()
        {
            Console.WriteLine("O animal está andando");
        }

    }
}
