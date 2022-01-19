using DinosaursLibrary.Application.Models.Responses;

namespace DinosaursLibrary.Application.Interfaces
{
    public interface IDinosaurService
    {
        IEnumerable<DinosaurResponse> GetAllDinosaurs();
        IEnumerable<DinosaurResponse> GetAllDinosaursByName(string name);
        DinosaurResponse? GetDinosaurById(int id);
    }
}