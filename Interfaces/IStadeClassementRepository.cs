using System.Collections.Generic;
using System.Threading.Tasks;
using GestionDesArchivesWebApp.Models;

namespace GestionDesArchivesWebApp.Interfaces
{
    public interface IStadeClassementRepository
    {
        Task<IEnumerable<StadeClassement>> GetAllAsync();
        Task<StadeClassement?> GetByIdAsync(string id);
        Task<bool> AddAsync(StadeClassement stadeClassement);
        Task<bool> UpdateAsync(StadeClassement stadeClassement);
        Task<bool> DeleteAsync(string id);
    }
}
