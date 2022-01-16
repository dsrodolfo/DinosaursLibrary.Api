using DinosaursLibrary.Domain.Entities;
using DinosaursLibrary.Domain.Enums;
using DinosaursLibrary.Infrastructure.Interfaces;

namespace DinosaursLibrary.Infrastructure.Repositories
{
    public class DinosaurRepository : RepositoryBase, IDinosaurRepository
    {
        private readonly IEnumerable<DinosaurEntity> _dinosaurs = new List<DinosaurEntity>()
        {
            new(){ Id = 1 , Name = "Tyrannosaurus Rex", PeriodId = Period.Cretaceous, LifeExpectancy = 28 },
            new(){ Id = 2 , Name = "Velociraptor", PeriodId = Period.Cretaceous, LifeExpectancy = 20 },
            new(){ Id = 3 , Name = "Triceratops", PeriodId = Period.Cretaceous }
        };

        public DinosaurRepository()
        {

        }

        public IEnumerable<DinosaurEntity> GetAllDinosaurs()
        {
            return _dinosaurs.OrderBy(x => x.Name);
        }

        public DinosaurEntity? GetDinosaur(int id)
        {
            return _dinosaurs.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}