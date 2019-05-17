using System;
using System.Data.Entity;

namespace CarService.Infrastructure.EF
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }
        void Commit();
    }
}
