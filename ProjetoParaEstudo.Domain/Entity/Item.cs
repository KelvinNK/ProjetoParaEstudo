using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Personagem Personagem { get; set; }
    }
}
