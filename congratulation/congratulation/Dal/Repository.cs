using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.Dal
{
  public class Repository
  {
    public congaratulationModelContainer db;

    public Repository(congaratulationModelContainer context)
    {
      db = context;
    }
  }
}