using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Ana : Caracteristicas
    {
        public string planeta { get; protected set; }

        public Ana(string nome, string cor, int idade, double tamanho, double peso)
        {
            this.nome = nome;
            this.cor = cor;
            this.idade = idade;
            this.tamanho = tamanho;
            this.peso = peso;
        }

        public override void Come()
        {
            this.peso += 2;
        }
    }
}
