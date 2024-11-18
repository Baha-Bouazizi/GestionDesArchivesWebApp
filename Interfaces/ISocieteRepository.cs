using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Models;

namespace GestionDesArchivesWebApp.Interfaces
{
    public interface ISocieteRepository
    {
        Task<IEnumerable<Societe>> GetAllAsync();
        Task<Societe?> GetByIdAsync(string id);
        Task<bool> AddAsync(Societe societe);
        Task<bool> UpdateAsync(Societe societe);
        Task<bool> DeleteAsync(string id);
    }
}
