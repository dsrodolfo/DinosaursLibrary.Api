using DinosaursLibrary.Domain.Enums;

namespace DinosaursLibrary.Application.Models.Responses
{
    public class DinosaurResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Period PeriodId { get; set; }
        public int? LifeExpectancy { get; set; }
    }
}