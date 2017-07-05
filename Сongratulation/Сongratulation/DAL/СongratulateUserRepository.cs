using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Сongratulation.Models;

namespace Сongratulation.DAL
{
  public class СongratulateUserRepository : IRepository<СongratulateUser>
  {
    private CongratulationContext db;

    public СongratulateUserRepository(CongratulationContext context)
    {
      this.db = context;
    }
    public void Create(СongratulateUser item)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public СongratulateUser Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<СongratulateUser> GetAll()
    {
      throw new NotImplementedException();
    }

    public void Update(СongratulateUser item)
    {
      throw new NotImplementedException();
    }
  }
}
