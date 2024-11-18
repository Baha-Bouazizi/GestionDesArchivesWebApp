using GestionDesArchivesWebApp.Models;

namespace GestionDesArchivesWebApp.Interfaces
{
    public interface ITypeClassementRepository
    {
        Task<IEnumerable<TypeClassement>> GetAllAsync();
        Task<TypeClassement?> GetByIdAsync(string id);
        Task<bool> AddAsync(TypeClassement typeClassement);
        Task<bool> UpdateAsync(TypeClassement typeClassement);
        Task<bool> DeleteAsync(string id);
    }
}
