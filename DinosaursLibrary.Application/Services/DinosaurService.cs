using DinosaursLibrary.Application.Interfaces;
using DinosaursLibrary.Application.Models.Responses;
using DinosaursLibrary.Infrastructure.Interfaces;
using Mapster;

namespace DinosaursLibrary.Application.Services
{
    public class DinosaurService : IDinosaurService
    {
        private readonly IDinosaurRepository _dinosaurRepository;

        public DinosaurService(IDinosaurRepository dinosaurRepository)
        {
            _dinosaurRepository = dinosaurRepository;
        }

        public IEnumerable<DinosaurResponse> GetAllDinosaurs()
        {
            var  dinosaurEntities = _dinosaurRepository.GetAllDinosaurs();
            var dinosaurResponses = dinosaurEntities.Adapt<IEnumerable<DinosaurResponse>>();

            return dinosaurResponses;
        }

        public DinosaurResponse? GetDinosaur(int id)
        {
            var dinosaurEntity = _dinosaurRepository.GetDinosaur(id);
            var response = dinosaurEntity.Adapt<DinosaurResponse>();

            return response;
        }
    }
}