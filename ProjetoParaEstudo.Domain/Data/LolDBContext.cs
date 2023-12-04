using ProjetoParaEstudo.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Data
{
    public class LolDBContext : DbContext
    {

        public LolDBContext(DbContextOptions<LolDBContext> options) : base(options)
        {

        }

        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Item> Itens { get; set; }
    }
}
