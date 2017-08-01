using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.Dal
{
  public class CongratulationCardRepository: IRepository<uc_Photo>
  {
    public congaratulationModelContainer _db;
    public CongratulationCardRepository(congaratulationModelContainer context)
    {
      _db = context;
    }
    public void Create(uc_Photo item)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public uc_Photo Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<uc_Photo> GetAll()
    {
      throw new NotImplementedException();
    }

    public void Update(uc_Photo item)
    {
      throw new NotImplementedException();
    }
  }
}