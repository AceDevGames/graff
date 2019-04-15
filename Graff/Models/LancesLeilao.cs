using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graff.Models
{
    public class LancesLeilao
    {
        public int id { get; set; }
        public double valor { get; set; }
        public Leilao Leilao { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }

        public LancesLeilao()
        {
        }

        public LancesLeilao(int id, double valor, Leilao leilao, Pessoa pessoa)
        {
            this.id = id;
            this.valor = valor;
            Leilao = leilao;
            Pessoa = pessoa;
        }
    }
}
