using Microsoft.EntityFrameworkCore;
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
      db.СongratulateUsers.Add(item);
    }

    public void Delete(int id)
    {
      СongratulateUser congratulateUser = db.СongratulateUsers.Find(id);
      if (congratulateUser != null)
      { db.СongratulateUsers.Remove(congratulateUser); }
    }

    public СongratulateUser Get(int id)
    {
      var res = db.СongratulateUsers.Find(id);
      return res;
    }

    public IEnumerable<СongratulateUser> GetAll()
    {
      var res = db.СongratulateUsers;
      return res;
    }

    public void Update(СongratulateUser item)
    {
      db.Entry(item).State = EntityState.Modified;
    }
  }
}
