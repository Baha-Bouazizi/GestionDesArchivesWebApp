using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Data;
using GestionDesArchivesWebApp.Interfaces;
using GestionDesArchivesWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDesArchivesWebApp.Repositories
{
    public class EmplacementRepository : IEmplacementRepository
    {
        private readonly ApplicationDbContext _context;

        public EmplacementRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Emplacement>> GetAllAsync()
        {
            return await _context.Emplacements.ToListAsync();
        }

        public async Task<Emplacement?> GetByIdAsync(string id)
        {
            return await _context.Emplacements.FindAsync(id);
        }

        public async Task<bool> AddAsync(Emplacement emplacement)
        {
            _context.Emplacements.Add(emplacement);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Emplacement emplacement)
        {
            _context.Entry(emplacement).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var emplacement = await _context.Emplacements.FindAsync(id);
            if (emplacement == null) return false;

            _context.Emplacements.Remove(emplacement);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
