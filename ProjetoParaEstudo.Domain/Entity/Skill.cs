using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Entity
{
    public class Skill
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Personagem Personagem { get; set; }
    }
}
