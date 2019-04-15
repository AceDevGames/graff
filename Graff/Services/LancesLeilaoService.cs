using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Graff.Models;
using Microsoft.EntityFrameworkCore;

namespace Graff.Services
{
    public class LancesLeilaoService
    {
        private readonly GraffContext _context;
        public LancesLeilaoService(GraffContext context)
        {
            _context = context;
        }

        public List<LancesLeilao> FindAll()
        {
            

            return _context.LancesLeilao.Include(obj =>  obj.Leilao.Produto).Include(obj =>  obj.Pessoa).ToList();
        }
        public void Insert(LancesLeilao obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public LancesLeilao FindById(int id)
        {
            return _context.LancesLeilao.FirstOrDefault(obj => obj.id == id);

        }

        public void Lance(int id)
        {
            var obj = _context.LancesLeilao.Find(id);
           // _context.LancesLeilao.Remove(obj);
           // _context.SaveChanges();
        }

    }
}
