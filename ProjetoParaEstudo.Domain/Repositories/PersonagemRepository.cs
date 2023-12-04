using ProjetoParaEstudo.Domain.Data;
using ProjetoParaEstudo.Domain.Entity;
using ProjetoParaEstudo.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParaEstudo.Domain.Repositories
{
    public class PersonagemRepository : IRepository<Personagem>
    {
        private readonly LolDBContext _context;

        public PersonagemRepository(LolDBContext context)
        {
            _context = context;
        }
        public async Task<Personagem> Create(Personagem entity)
        {
            _context.Personagens.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<int> Delete(int id)
        {
            var personagem = await _context.Personagens.FindAsync(id);

            if (personagem is null)
                throw new ArgumentException("O Id fornecido não existe.");

            _context.Personagens.Remove(personagem);
            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<Personagem> Get(int id)
        {
            var personagem = await _context.Personagens.Include(x => x.Itens).Include(x => x.Skills).FirstOrDefaultAsync(x => x.Id == id);

            return personagem;
        }

        public async Task<List<Personagem>?> GetAll()
        {
            var personagem = await _context.Personagens.Include(x => x.Itens).Include(x => x.Skills).ToListAsync();

            return personagem.Count > 0 ? personagem : null;
        }

        public async Task<Personagem> Update(Personagem entity)
        {
            _context.Personagens.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
