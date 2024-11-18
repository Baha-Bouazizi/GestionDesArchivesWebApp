using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Data;
using GestionDesArchivesWebApp.Interfaces;
using GestionDesArchivesWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDesArchivesWebApp.Repositories
{
    public class StadeClassementRepository : IStadeClassementRepository
    {
        private readonly ApplicationDbContext _context;

        public StadeClassementRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StadeClassement>> GetAllAsync()
        {
            return await _context.StadeClassements.ToListAsync();
        }

        public async Task<StadeClassement?> GetByIdAsync(string id)
        {
            return await _context.StadeClassements.FindAsync(id);
        }

        public async Task<bool> AddAsync(StadeClassement stadeClassement)
        {
            _context.StadeClassements.Add(stadeClassement);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(StadeClassement stadeClassement)
        {
            _context.Entry(stadeClassement).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var stadeClassement = await _context.StadeClassements.FindAsync(id);
            if (stadeClassement == null) return false;

            _context.StadeClassements.Remove(stadeClassement);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
