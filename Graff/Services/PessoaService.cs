using Graff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graff.Services
{
    public class PessoaService
    {
        private readonly GraffContext _context;

        public PessoaService(GraffContext context)
        {
            _context = context;
        }

        public List<Pessoa> FindAll()
        {
            return _context.Pessoa.ToList();
        }

        public void Insert(Pessoa obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }

}
