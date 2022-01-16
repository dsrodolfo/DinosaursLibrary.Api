using DinosaursLibrary.Domain.Entities;

namespace DinosaursLibrary.Infrastructure.Interfaces
{
    public interface IDinosaurRepository
    {
        IEnumerable<DinosaurEntity> GetAllDinosaurs();
        DinosaurEntity? GetDinosaur(int id);
    }
}
