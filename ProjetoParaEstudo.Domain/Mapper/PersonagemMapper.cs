using AutoMapper;
using ProjetoParaEstudo.Domain.Commands.Requests;
using ProjetoParaEstudo.Domain.Commands.Responses;
using ProjetoParaEstudo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Mapper
{
    public class PersonagemMapper : Profile
    {

        public PersonagemMapper()
        {
            CreateMap<CreatePersonagemRequest, Personagem>();
            CreateMap<CreatePersonagemRequest.CreatePersonagemItemRequest, Item>();
            CreateMap<CreatePersonagemRequest.CreatePersonagemSkillRequest, Skill>();

            CreateMap<Personagem, CreatePersonagemResponse>();
            CreateMap<Item, CreatePersonagemResponse.CreatePersonagemItemResponse>();
            CreateMap<Skill, CreatePersonagemResponse.CreatePersonagemSkillResponse>();

            CreateMap<UpdatePersonagemRequest, Personagem>();
            CreateMap<UpdatePersonagemRequest.UpdatePersonagemItemRequest, Item>();
            CreateMap<UpdatePersonagemRequest.UpdatePersonagemSkillRequest, Skill>();

            CreateMap<Personagem, UpdatePersonagemResponse>();
            CreateMap<Item, UpdatePersonagemResponse.UpdatePersonagemItemResponse>();
            CreateMap<Skill, UpdatePersonagemResponse.UpdatePersonagemSkillResponse>();

            CreateMap<Personagem, GetPersonagemResponse>();
            CreateMap<Item, GetPersonagemResponse.GetPersonagemItemResponse>();
            CreateMap<Skill, GetPersonagemResponse.GetPersonagemSkillResponse>();

            CreateMap<Personagem, GetAllPersonagemResponse>();
            CreateMap<Item, GetAllPersonagemResponse.GetAllPersonagemItemResponse>();
            CreateMap<Skill, GetAllPersonagemResponse.GetAllPersonagemSkillResponse>();
        }
    }
}
