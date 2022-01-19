using DinosaursLibrary.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace DinosaursLibrary.Infrastructure.Repositories
{
    public class RepositoryBase : IRepositoryBase, IDisposable
    {
        public IDbConnection DbConnection { get; set; }
        public RepositoryBase(IConfiguration configuration)
        {
            DbConnection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            DbConnection.Open();
        }
        public void Dispose() => DbConnection?.Dispose();
    }
}