﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Entity
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public List<Item> Itens { get; set; }
        public List<Skill> Skills { get; set; }

    }
}
