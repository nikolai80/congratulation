using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using congratulation.Dal;
using AutoMapper;
using congratulation.Models;

namespace congratulation.BLL.DTO
{
  public class UserService : IUserService
  {
    UnitOfWork Db { get; set; }

    public UserService(UnitOfWork database)
    {
      Db = database;
    }
    public void Dispose()
    {
      Db.Dispose();
    }

    public IEnumerable<UserDto> GetAllUsers()
    {
      Mapper.Initialize(cfg => cfg.CreateMap<uc_User, UserDto>());
      return Mapper.Map<IEnumerable<uc_User>, List<UserDto>>(Db.UserRepository.GetAll());
    }

    public UserDto GetUser(int? id)
    {
      UserDto res = null;
      if (id==null)
      {
        throw new ArgumentException("id не может быть null");
      }
      var user = Db.UserRepository.Get(id.Value);
      if (user==null)
      {
        throw new Exception("Пользхователь не найден");
      }
      else
      {
        Mapper.Initialize(cfg => cfg.CreateMap<uc_User, UserDto>());
        res = Mapper.Map<uc_User, UserDto>(user);
      }
      return res;
    }
  }
}