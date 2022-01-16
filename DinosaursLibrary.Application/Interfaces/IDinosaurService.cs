using DinosaursLibrary.Application.Models.Responses;

namespace DinosaursLibrary.Application.Interfaces
{
    public interface IDinosaurService
    {
        IEnumerable<DinosaurResponse> GetAllDinosaurs();
        DinosaurResponse? GetDinosaur(int id);
    }
}