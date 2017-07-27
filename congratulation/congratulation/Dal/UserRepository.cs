using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace congratulation.Dal
{
  public class UserRepository : Repository, IRepository<uc_User>
  {
    public UserRepository(congaratulationModelContainer context) : base(context)
    {
    }
    public void Create(uc_User item)
    {
      db.uc_UserSet.Add(item);
    }

    public void Delete(int id)
    {
     var user= db.uc_UserSet.Find(id);
      if (user!=null)
      {
        db.uc_UserSet.Remove(user);
      }
    }

    public uc_User Get(int id)
    {
      uc_User res = new uc_User();

      try
      {
        db.uc_UserSet.Find(id);
      }
      catch (Exception ex)
      {
        throw;
      }

      return res;
    }

    public IEnumerable<uc_User> GetAll()
    {

      var res = db.uc_UserSet;
      return res;
    }

    public void Update(uc_User item)
    {
      db.Entry(item).State = EntityState.Modified;
    }
  }
}