using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graff.Models
{
    public class Produto
    {
        public int id { get; set; }
        public String nome { get; set; }
        public Double valor { get; set; }
        public ICollection<Leilao> Leiloes { get; set; } = new List<Leilao>();

        public Produto()
        {

        }

        public Produto(int id, string nome, double valor)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
        }

        public void adicionaLeilao(Leilao leilao)
        {
            Leiloes.Add(leilao);
        }
    }
}
