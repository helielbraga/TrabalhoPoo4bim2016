using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Caracteristicas : IPessoa
    {
        public string nome { get; protected set; }
        public string cor { get; protected set; }
        public int idade { get; protected set; }
        public double tamanho { get; protected set; }
        public double peso { get; protected set; }
        public bool nasce { get; protected set; }

        public virtual void Come()
        {
            this.peso += 1;
        }

        public void Exercita()
        {
            this.peso -= 0.5;
        }

        public void Cresce()
        {
            this.tamanho += 0.2;
        }

        public void Aniversario(float idade)
        {
            this.idade += (int) idade;
        }

        public bool Nascer() {
           return this.nasce = true;
        }
    }
}
