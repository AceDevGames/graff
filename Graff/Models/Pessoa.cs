using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graff.Models
{
    public class Pessoa
    {
        public int id { get; set; }
        public String nome { get; set; }
        public int idade { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int id, string nome, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
        }
    }
}
