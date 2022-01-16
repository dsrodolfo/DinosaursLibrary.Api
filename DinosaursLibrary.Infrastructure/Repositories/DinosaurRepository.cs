using DinosaursLibrary.Domain.Entities;
using DinosaursLibrary.Infrastructure.Interfaces;

namespace DinosaursLibrary.Infrastructure.Repositories
{
    public class DinosaurRepository : RepositoryBase, IDinosaurRepository
    {
        private readonly IEnumerable<DinosaurEntity> _dinosaurs = new List<DinosaurEntity>()
        {
            new(){ Id = 1 , Name = "Tyrannosaurus Rex", PeriodId = 1 },
            new(){ Id = 1 , Name = "Velociraptor", PeriodId = 1 },
            new(){ Id = 1 , Name = "Triceratops", PeriodId = 1 }
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