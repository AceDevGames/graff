
using System.Collections.Generic;


namespace Graff.Models.ViewModels
{
    public class LancesLeilaoFormViewModel
    {
        public LancesLeilao LancesLeilao { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; }
        public ICollection<Leilao> Leiloes { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
