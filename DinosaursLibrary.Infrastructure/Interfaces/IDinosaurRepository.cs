using DinosaursLibrary.Domain.Entities;

namespace DinosaursLibrary.Infrastructure.Interfaces
{
    public interface IDinosaurRepository
    {
        IEnumerable<DinosaurEntity> GetAllDinosaurs();
        IEnumerable<DinosaurEntity> GetAllDinosaursByName(string name);
        DinosaurEntity? GetDinosaurById(int id);
    }
}