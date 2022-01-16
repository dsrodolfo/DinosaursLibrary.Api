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
            var  dinosaurEntities = _dinosaurRepository.GetAllDinosaurs();
            var dinosaurResponses = _mapper.Map<IEnumerable<DinosaurResponse>>(dinosaurEntities);

            return dinosaurResponses;
        }

        public DinosaurResponse? GetDinosaur(int id)
        {
            var dinosaurEntity = _dinosaurRepository.GetDinosaur(id);
            DinosaurResponse response = _mapper.Map<DinosaurResponse>(dinosaurEntity);

            return response;
        }
    }
}