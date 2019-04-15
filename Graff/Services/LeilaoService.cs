using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Graff.Models;
using Microsoft.EntityFrameworkCore;

namespace Graff.Services
{
    public class LeilaoService
    {
        private readonly GraffContext _context;
        public LeilaoService(GraffContext context)
        {
            _context = context;
        }

        public List<Leilao> FindAll()
        {
            return _context.Leilao.Include(obj => obj.Produto).ToList();
        }
        public void Insert(Leilao obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Leilao FindById(int id)
        {
            return _context.Leilao.Include(obj => obj.Produto).FirstOrDefault(obj => obj.id == id);

        }

        public void Remove(int id)
        {
            var obj = _context.Leilao.Find(id);
            _context.Leilao.Remove(obj);
            _context.SaveChanges();
        }
    }
}
