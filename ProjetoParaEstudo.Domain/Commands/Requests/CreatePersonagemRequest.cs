using ProjetoParaEstudo.Domain.Commands.Responses;
using MediatR;

namespace ProjetoParaEstudo.Domain.Commands.Requests
{
    public class CreatePersonagemRequest : IRequest<CreatePersonagemResponse>
    {
        public string Nome { get; set; }
        public List<CreatePersonagemItemRequest>? Itens { get; set; }
        public List<CreatePersonagemSkillRequest>? Skills { get; set; }

        public class CreatePersonagemItemRequest
        {
            public string Nome { get; set; }
        }

        public class CreatePersonagemSkillRequest
        {
            public string Nome { get; set; }
        }
    }
}
