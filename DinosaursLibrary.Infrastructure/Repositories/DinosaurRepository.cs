using Dapper;
using DinosaursLibrary.Domain.Entities;
using DinosaursLibrary.Infrastructure.Interfaces;

namespace DinosaursLibrary.Infrastructure.Repositories
{
    public class DinosaurRepository : IDinosaurRepository
    {
        private readonly IRepositoryBase _repositoryBase;

        public DinosaurRepository(IRepositoryBase repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public IEnumerable<DinosaurEntity> GetAllDinosaurs()
        {
            using var db = _repositoryBase.DbConnection;
            string sql = "SELECT * FROM Dinosaur;";

            return db.Query<DinosaurEntity>(sql);
        }

        public IEnumerable<DinosaurEntity> GetAllDinosaursByName(string name)
        {
            using var db = _repositoryBase.DbConnection;
            string sql = @"SELECT * FROM Dinosaur
                           WHERE LOWER(name) LIKE CONCAT(@name, '%')";

            var param = new { name = name.ToLower().Trim() };

            return db.Query<DinosaurEntity>(sql, param);
        }

        public DinosaurEntity? GetDinosaurById(int id)
        {
            using var db = _repositoryBase.DbConnection;
            string sql = @"SELECT * FROM Dinosaur 
                           WHERE id = @id;";

            var param = new { id };

            return db.QueryFirstOrDefault<DinosaurEntity>(sql, param);
        }
    }
}