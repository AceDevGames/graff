using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Graff.Models;

namespace Graff.Data
{
    public class SeedingService
    {
        private GraffContext _context;

        public SeedingService(GraffContext context)
        {
            _context = context;
        }
        public void Sedd()
        {
            if(_context.Produto.Any() ||_context.Pessoa.Any() || _context.Leilao.Any())
            {
                return; // banco ja populado
            }
            Produto p1 = new Produto(1, "TV 32", 499.00);
            Produto p2 = new Produto(2, "Celular Hiphone XXX", 679.00);
            Produto p3 = new Produto(3, "Radio Carro Pionner", 199.00);

            Pessoa pp1 = new Pessoa(1,"Jao da Silva",23);
            Pessoa pp2 = new Pessoa(2,"Epaminondas Ratch",66);
            Pessoa pp3 = new Pessoa(3,"Maria Porcina",71);
            Pessoa pp4 = new Pessoa(4,"Pedro Boh",18);
            Pessoa pp5 = new Pessoa(5,"Chico Bentho",17);

            Leilao l1 = new Leilao(1,545.89,p1);

            LancesLeilao ll1 = new LancesLeilao(1, 655.45, l1, pp3);

            _context.Produto.AddRange(p1, p2, p3);

            _context.Pessoa.AddRange(pp1, pp2, pp3, pp4, pp5);

            _context.Leilao.AddRange(l1);

            _context.LancesLeilao.AddRange(ll1);

            _context.SaveChanges();
        }
    }
}
