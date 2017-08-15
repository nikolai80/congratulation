using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using AutoMapper;
using congratulation.Dal;
using congratulation.Models;

namespace congratulation.BLL.Services
{
  public class CongratulationCardService : ICongratulationCardService
  {
   IUnitOfWork db { get; set; }
    public CongratulationCardService(IUnitOfWork dataBase)
    {
      db = dataBase;
    }
    public void AddCard(CongratulationCardDto cardDto)
    {
      uc_User user = db.UserRepository.Get(cardDto.User.Id);
      if (user==null)
      {
        throw new Exception("Не указан пользователь создающий поздравление");
      }
      else
      {
        uc_CongratulationCard card = new uc_CongratulationCard {
          HeaderText=cardDto.HeaderText,
          Whom=cardDto.Whom
        };
        db.CongratulationCardRepository.Create(card);
        db.Save();
      }
     
    }

    public void EditCard(CongratulationCardDto cardDto)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      db.Dispose();
    }
  }
}