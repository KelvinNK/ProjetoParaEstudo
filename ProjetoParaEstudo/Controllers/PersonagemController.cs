using AutoMapper;
using ProjetoParaEstudo.Domain.Commands.Requests;
using ProjetoParaEstudo.Domain.Commands.Responses;
using ProjetoParaEstudo.Domain.Entity;
using ProjetoParaEstudo.Domain.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoParaEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Personagem> _personagemRepostiory;
        private readonly IMapper _mapper;
        public PersonagemController(IMediator mediator, IRepository<Personagem> personagemRepostiory, IMapper mapper)
        {
            _mediator = mediator;
            _personagemRepostiory = personagemRepostiory;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var personagens = await _personagemRepostiory.GetAll();
            if (personagens is null || !personagens.Any())
                return NoContent();

            var response = new List<GetAllPersonagemResponse>();            
            personagens.ForEach(x =>  response.Add(_mapper.Map<GetAllPersonagemResponse>(x)));

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var personagem = await _personagemRepostiory.Get(id);
            var response = _mapper.Map<GetPersonagemResponse>(personagem);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePersonagemRequest request)
        {
            var response = await _mediator.Send(request);
            return Created($"api/personagem/{response.Id}", response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdatePersonagemRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var request = new DeletePersonagemRequest { Id = id };
            var response = await _mediator.Send(request);

            return Ok(response);
        }

    }
}
