using DinosaursLibrary.Application.Interfaces;
using DinosaursLibrary.Application.Models.Responses;
using DinosaursLibrary.Infrastructure.Interfaces;
using MapsterMapper;

namespace DinosaursLibrary.Application.Services
{
    public class DinosaurService : IDinosaurService
    {
        private readonly IDinosaurRepository _dinosaurRepository;
        private readonly IMapper _mapper;

        public DinosaurService(IDinosaurRepository dinosaurRepository, 
                               IMapper mapper)
        {
            _dinosaurRepository = dinosaurRepository;
            _mapper = mapper;
        }

        public IEnumerable<DinosaurResponse> GetAllDinosaurs()
        {
            var dinosaurEntities = _dinosaurRepository.GetAllDinosaurs();
            var dinosaurResponses = _mapper.Map<IEnumerable<DinosaurResponse>>(dinosaurEntities);

            return dinosaurResponses;
        }

        public IEnumerable<DinosaurResponse> GetAllDinosaursByName(string name)
        {
            var dinosaurEntities = _dinosaurRepository.GetAllDinosaursByName(name);
            var dinosaurResponses = _mapper.Map<IEnumerable<DinosaurResponse>>(dinosaurEntities);

            return dinosaurResponses;
        }

        public DinosaurResponse? GetDinosaurById(int id)
        {
            var dinosaurEntity = _dinosaurRepository.GetDinosaurById(id);
            DinosaurResponse? response = dinosaurEntity != null ? 
                _mapper.Map<DinosaurResponse>(dinosaurEntity) :
                null;

            return response;
        }
    }
}