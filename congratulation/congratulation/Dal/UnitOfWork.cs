﻿using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.Dal
{
  public class UnitOfWork : IDisposable
  {
    private bool disposed = false;
    private congaratulationModelContainer db = new congaratulationModelContainer();
    private UserRepository userRepository;
    private CongratulationCardRepository congratulationCardRepository;
    private CongratulationRepository congratulationRepository;
    private GiftRepository giftRepository;
    private PhotoRepository photoRepository;

    public UserRepository UserRepository
    {
      get
      {
        if (userRepository == null) { userRepository = new UserRepository(db); }
        return userRepository;
      }
    }
    public CongratulationCardRepository CongratulationCardRepository
    {
      get
      {
        if (congratulationCardRepository == null)
        {
          congratulationCardRepository = new CongratulationCardRepository(db);
        }
        return congratulationCardRepository;
      }
    }

    public CongratulationRepository CongratulationRepository
    {
      get
      {
        if (congratulationRepository == null)
        {
          congratulationRepository = new CongratulationRepository(db);
        }
        return congratulationRepository;
      }
    }

    public GiftRepository GiftRepository
    {
      get
      {
        if (giftRepository == null)
        {
          giftRepository = new GiftRepository(db);
        }
        return giftRepository;
      }
    }

    public PhotoRepository PhotoRepository
    {
      get
      {
        if (photoRepository == null)
        {
          photoRepository = new PhotoRepository(db);
        }
        return photoRepository;
      }
    }
    public void Save()
    {
      db.SaveChanges();
    }
    public virtual void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          db.Dispose();
        }
        this.disposed = true;
      }
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}