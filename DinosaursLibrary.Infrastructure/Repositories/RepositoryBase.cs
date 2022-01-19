using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace DinosaursLibrary.Infrastructure.Repositories
{
    public class RepositoryBase : IDisposable
    {
        public IDbConnection DbConnection { get; }

        public RepositoryBase(IConfiguration configuration)
        {
            DbConnection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            DbConnection.Open();
        }

        public void Dispose() => DbConnection?.Dispose();
    }
}