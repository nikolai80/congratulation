using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сongratulation.Models;

namespace Сongratulation.DAL
{
  public class UnitOfWork : IDisposable
  {
    private CongratulationContext db;
    private СongratulateUserRepository congratulateUserRepository;

    public UnitOfWork(CongratulationContext context)
    {
      db = context;
    }
    public СongratulateUserRepository СongratulateUsers
    {
      get
      {
        if (congratulateUserRepository == null)
        {
          congratulateUserRepository = new СongratulateUserRepository(db);
        }
        return congratulateUserRepository;
      }
    }

    public void Save()
    {
      db.SaveChanges();
    }

    private bool disposed = false;
    public virtual void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          db.Dispose();
        }
        this.disposed = true;
      }
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}
