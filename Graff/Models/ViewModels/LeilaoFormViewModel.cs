
using System.Collections.Generic;


namespace Graff.Models.ViewModels
{
    public class LeilaoFormViewModel
    {
        public Leilao Leilao { get; set; }
        public ICollection<Produto> Produtos { get; set; }

    }
}
