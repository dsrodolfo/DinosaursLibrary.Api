using Dapper;
using DinosaursLibrary.Domain.Entities;
using DinosaursLibrary.Infrastructure.Interfaces;

namespace DinosaursLibrary.Infrastructure.Repositories
{
    public class DinosaurRepository : IDinosaurRepository
    {
        private readonly RepositoryBase _repositoryBase;

        public DinosaurRepository(RepositoryBase repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public IEnumerable<DinosaurEntity> GetAllDinosaurs()
        {
            using var db = _repositoryBase.DbConnection;
            string sql = "SELECT * FROM Dinosaur;";

            return db.Query<DinosaurEntity>(sql);
        }

        public DinosaurEntity? GetDinosaur(int id)
        {
            using var db = _repositoryBase.DbConnection;
            string sql = @"SELECT * FROM Dinosaur 
                           WHERE id = @id;";

            var param = new { id };

            return db.QueryFirstOrDefault<DinosaurEntity>(sql, param);
        }
    }
}