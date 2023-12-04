using ProjetoParaEstudo.Domain.Commands.Requests;
using ProjetoParaEstudo.Domain.Entity;
using ProjetoParaEstudo.Domain.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Handlers
{
    public class DeletePersonagemHandler : IRequestHandler<DeletePersonagemRequest, string>
    {
        private readonly IRepository<Personagem> _personagemRepository;
        public DeletePersonagemHandler(IRepository<Personagem> personagemRepository)
        {
            _personagemRepository = personagemRepository;
        }
        public async Task<string> Handle(DeletePersonagemRequest request, CancellationToken cancellationToken)
        {
            var idDeleted = await _personagemRepository.Delete(request.Id);

            var response = $"O registro Id: {idDeleted} foi apagado.";

            return response;
        }
    }
}
