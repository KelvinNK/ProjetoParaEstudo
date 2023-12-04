using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Commands.Responses
{
    public class GetPersonagemResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<GetPersonagemItemResponse> Itens { get; set; }
        public List<GetPersonagemSkillResponse> Skills { get; set; }

        public class GetPersonagemItemResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        public class GetPersonagemSkillResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
