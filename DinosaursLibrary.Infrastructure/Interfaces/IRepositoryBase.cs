using Microsoft.Extensions.Configuration;
using System.Data;

namespace DinosaursLibrary.Infrastructure.Interfaces
{
    public interface IRepositoryBase
    {
        IDbConnection DbConnection { get; set; }
    }
}