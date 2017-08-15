using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using congratulation.Models;

namespace congratulation.Dal
{
  public class GiftRepository : IRepository<uc_Gift>
  {
    public congaratulationModelContainer _db;
    public GiftRepository(congaratulationModelContainer context)
    {
      _db = context;
    }

    public void Create(uc_Gift item)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public uc_Gift Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<uc_Gift> GetAll()
    {
      throw new NotImplementedException();
    }

    public void Update(uc_Gift item)
    {
      throw new NotImplementedException();
    }
  }
}