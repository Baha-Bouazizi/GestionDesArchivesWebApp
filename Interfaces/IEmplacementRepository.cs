using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Models;

namespace GestionDesArchivesWebApp.Interfaces
{
    public interface IEmplacementRepository
    {
        Task<IEnumerable<Emplacement>> GetAllAsync();
        Task<Emplacement?> GetByIdAsync(string id);
        Task<bool> AddAsync(Emplacement emplacement);
        Task<bool> UpdateAsync(Emplacement emplacement);
        Task<bool> DeleteAsync(string id);
    }
}
