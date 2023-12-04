using AutoMapper;
using ProjetoParaEstudo.Domain.Commands.Requests;
using ProjetoParaEstudo.Domain.Commands.Responses;
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
    public class UpdatePersonagemHandler : IRequestHandler<UpdatePersonagemRequest, UpdatePersonagemResponse>
    {
        private readonly IRepository<Personagem> _personagemRepository;
        private readonly IMapper _mapper;

        public UpdatePersonagemHandler(IRepository<Personagem> personagemRepository, IMapper mapper)
        {
            _personagemRepository = personagemRepository;
            _mapper = mapper;
        }
        public async Task<UpdatePersonagemResponse> Handle(UpdatePersonagemRequest request, CancellationToken cancellationToken)
        {
            var personagem = _mapper.Map<Personagem>(request);

            var createdPersonagem = await _personagemRepository.Update(personagem);

            var response = _mapper.Map<UpdatePersonagemResponse>(createdPersonagem);

            return response;
        }
    }
}
