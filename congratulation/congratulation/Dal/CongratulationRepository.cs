﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using congratulation.Models;

namespace congratulation.Dal
{
  public class CongratulationRepository : IRepository<uc_Congratulation>
  {
    public congaratulationModelContainer _db;
    public CongratulationRepository(congaratulationModelContainer context) 
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