using GestionDesArchivesWebApp.Models;

namespace GestionDesArchivesWebApp.Interfaces
{
    public interface ISupportRepository
    {
        Task<IEnumerable<Support>> GetAllAsync();
        Task<Societe?> GetByIdAsync(string id);
        Task<bool> AddAsync(Support support);
        Task<bool> UpdateAsync(Support support);
        Task<bool> DeleteAsync(string id);
    }
}
