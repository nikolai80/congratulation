using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.Dal
{
  public class UserRepository :Repository, IRepository<uc_User>
  {
    public UserRepository(congaratulationModelContainer context):base(context)
    {
    }
    public void Create(uc_User item)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public uc_User Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<uc_User> GetAll()
    {
      throw new NotImplementedException();
    }

    public void Update(uc_User item)
    {
      throw new NotImplementedException();
    }
  }
}