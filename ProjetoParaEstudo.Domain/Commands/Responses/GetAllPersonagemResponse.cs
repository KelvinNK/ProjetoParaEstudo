using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Commands.Responses
{
    public class GetAllPersonagemResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<GetAllPersonagemItemResponse> Itens { get; set; }
        public List<GetAllPersonagemSkillResponse> Skills { get; set; }

        public class GetAllPersonagemItemResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        public class GetAllPersonagemSkillResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
