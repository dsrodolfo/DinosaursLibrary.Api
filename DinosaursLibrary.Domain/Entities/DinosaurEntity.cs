using DinosaursLibrary.Domain.Enums;

namespace DinosaursLibrary.Domain.Entities
{
    public class DinosaurEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Period PeriodId { get; set; }
        public int? LifeExpectancy { get; set; }
    }
}