using MediatR;

namespace ProjetoParaEstudo.Domain.Commands.Requests
{
    public class DeletePersonagemRequest :  IRequest<string>
    {
        public int Id { get; set; }
    }
}
