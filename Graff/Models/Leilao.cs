using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graff.Models
{
    public class Leilao
    {
        public int id { get; set; }
        public double valorLance { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }


        public Leilao()
        {

        }

        public Leilao(int id, double valorLance, Produto produto)
        {
            this.id = id;
            this.valorLance = valorLance;
            Produto = produto;
         
        }
    }
}
