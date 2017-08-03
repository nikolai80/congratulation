﻿using congratulation.Dal;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.Infrastructure
{
  public class ServiceModule : NinjectModule
  {
    private string connectionString;

    public ServiceModule(string connection)
    {
      connectionString = connection;
    }

    public override void Load()
    {
      Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(connectionString);
    }
  }
}