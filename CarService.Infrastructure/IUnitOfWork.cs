using System;
using Microsoft.EntityFrameworkCore;

namespace CarService.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }
        void Commit();
    }
}
