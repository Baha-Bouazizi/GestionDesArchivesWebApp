using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Data;
using GestionDesArchivesWebApp.Interfaces;
using GestionDesArchivesWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDesArchivesWebApp.Repositories
{
    public class TypeClassementRepository : ITypeClassementRepository
    {
        private readonly ApplicationDbContext _context;

        public TypeClassementRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TypeClassement>> GetAllAsync()
        {
            return await _context.TypeClassements.ToListAsync();
        }

        public async Task<TypeClassement?> GetByIdAsync(string id)
        {
            return await _context.TypeClassements.FindAsync(id);
        }

        public async Task<bool> AddAsync(TypeClassement typeClassement)
        {
            _context.TypeClassements.Add(typeClassement);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(TypeClassement typeClassement)
        {
            _context.Entry(typeClassement).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var typeClassement = await _context.TypeClassements.FindAsync(id);
            if (typeClassement == null) return false;

            _context.TypeClassements.Remove(typeClassement);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
