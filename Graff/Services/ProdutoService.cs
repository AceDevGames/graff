using Graff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graff.Services
{
    public class ProdutoService
    {
        private readonly GraffContext _context;
        public ProdutoService(GraffContext context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.ToList();
        }

        public void Insert(Produto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
