using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.Dal
{
  public class CongratulationCardRepository: IRepository<uc_CongratulationCard>
  {
    public congaratulationModelContainer _db;
    public CongratulationCardRepository(congaratulationModelContainer context)
    {
      _db = context;
    }
    public void Create(uc_CongratulationCard item)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public uc_CongratulationCard Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<uc_CongratulationCard> GetAll()
    {
      throw new NotImplementedException();
    }

    public void Update(uc_CongratulationCard item)
    {
      throw new NotImplementedException();
    }
  }
}