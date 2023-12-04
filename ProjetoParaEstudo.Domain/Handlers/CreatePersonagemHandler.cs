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
    public class CreatePersonagemHandler : IRequestHandler<CreatePersonagemRequest, CreatePersonagemResponse>
    {
        private readonly IRepository<Personagem> _personagemRepository;
        private readonly IMapper _mapper;

        public CreatePersonagemHandler(IRepository<Personagem> personagemRepository, IMapper mapper)
        {
            _personagemRepository = personagemRepository;
            _mapper = mapper;
        }
        public async Task<CreatePersonagemResponse> Handle(CreatePersonagemRequest request, CancellationToken cancellationToken)
        {
            var personagem = _mapper.Map<Personagem>(request);

            var createdPersonagem = await _personagemRepository.Create(personagem);

            var response = _mapper.Map<CreatePersonagemResponse>(createdPersonagem);

            return response;
        }
    }
}
