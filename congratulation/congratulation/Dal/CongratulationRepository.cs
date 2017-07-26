using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using congratulation.Models;

namespace congratulation.Dal
{
  public class CongratulationRepository : Repository, IRepository<uc_CongratulationCard>
  {
    public CongratulationRepository(congaratulationModelContainer context) : base(context)
    {
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