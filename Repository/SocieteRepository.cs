using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Data;
using GestionDesArchivesWebApp.Interfaces;
using GestionDesArchivesWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDesArchivesWebApp.Repositories
{
    public class SocieteRepository : ISocieteRepository
    {
        private readonly ApplicationDbContext _context;

        public SocieteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Societe>> GetAllAsync()
        {
            return await _context.Societes.ToListAsync();
        }

        public async Task<Societe?> GetByIdAsync(string id)
        {
            return await _context.Societes.FindAsync(id);
        }

        public async Task<bool> AddAsync(Societe societe)
        {
            _context.Societes.Add(societe);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Societe societe)
        {
            _context.Entry(societe).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var societe = await _context.Societes.FindAsync(id);
            if (societe == null) return false;

            _context.Societes.Remove(societe);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
