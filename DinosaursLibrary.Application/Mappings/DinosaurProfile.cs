using DinosaursLibrary.Application.Models.Responses;
using DinosaursLibrary.Domain.Entities;
using Mapster;

namespace DinosaursLibrary.Application.Mappings
{
    public class MappingRegistration : IRegister
    {
        void IRegister.Register(TypeAdapterConfig config)
        {
            config.NewConfig<DinosaurEntity, DinosaurResponse>();
        }
    }
}
