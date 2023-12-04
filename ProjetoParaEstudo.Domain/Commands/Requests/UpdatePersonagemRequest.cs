using ProjetoParaEstudo.Domain.Commands.Responses;
using MediatR;

namespace ProjetoParaEstudo.Domain.Commands.Requests
{
    public class UpdatePersonagemRequest : IRequest<UpdatePersonagemResponse>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<UpdatePersonagemItemRequest> Itens { get; set; }
        public List<UpdatePersonagemSkillRequest> Skills { get; set; }

        public class UpdatePersonagemItemRequest
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        public class UpdatePersonagemSkillRequest
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
