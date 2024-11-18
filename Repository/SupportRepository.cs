using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Data;
using GestionDesArchivesWebApp.Interfaces;
using GestionDesArchivesWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDesArchivesWebApp.Repositories
{
    public class SupportRepository : ISupportRepository
    {
        private readonly ApplicationDbContext _context;

        public SupportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Support>> GetAllAsync()
        {
            return await _context.Supports.ToListAsync();
        }

        public async Task<Support?> GetByIdAsync(string id)
        {
            return await _context.Supports.FindAsync(id);
        }

        public async Task<bool> AddAsync(Support support)
        {
            _context.Supports.Add(support);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Support support)
        {
            _context.Entry(support).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var support = await _context.Supports.FindAsync(id);
            if (support == null) return false;

            _context.Supports.Remove(support);
            return await _context.SaveChangesAsync() > 0;
        }

        Task<Societe?> ISupportRepository.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
