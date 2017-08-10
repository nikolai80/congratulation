using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace congratulation.Dal
{
  public class UserRepository : IRepository<uc_User>
  {
    public congaratulationModelContainer _db;
    public UserRepository(congaratulationModelContainer context)
    {
      _db = context;
    }
    public void Create(uc_User item)
    {
      _db.uc_UserSet.Add(item);
    }

    public void Delete(int id)
    {
     var user= _db.uc_UserSet.Find(id);
      if (user!=null)
      {
        _db.uc_UserSet.Remove(user);
      }
    }

    public uc_User Get(int id)
    {
      uc_User res = new uc_User();

      try
      {
        _db.uc_UserSet.Find(id);
      }
      catch (Exception ex)
      {
        throw;
      }

      return res;
    }

    public IEnumerable<uc_User> GetAll()
    {

      var res = _db.uc_UserSet.Include(cc=>cc.uc_CongratulationCard).ToList();
      return res;
    }

    public void Update(uc_User item)
    {
      _db.Entry(item).State = EntityState.Modified;
    }
  }
}