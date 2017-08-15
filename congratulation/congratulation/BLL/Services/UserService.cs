using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using congratulation.Dal;
using AutoMapper;

using congratulation.Models;

namespace congratulation.BLL
{
  public class UserService : IUserService
  {
    IUnitOfWork db { get; set; }

    public UserService(IUnitOfWork dataBase)
    {
      db = dataBase;
    }
    public void Dispose()
    {
      db.Dispose();
    }

    public IEnumerable<UserDto> GetAllUsers()
    {
      var users = db.UserRepository.GetAll();
      Mapper.Initialize(cfg =>
      {
        cfg.CreateMap<uc_Photo, PhotoDto>().ForMember(dest => dest.CongratulationCard, opc => opc.MapFrom(src => src.uc_CongratulationCard));
        cfg.CreateMap<uc_Gift, GiftDto>().ForMember(dest => dest.CongratulationCards, opc => opc.MapFrom(src => src.uc_CongratulationCard));
        cfg.CreateMap<uc_Congratulation, CongratulationDto>();
        cfg.CreateMap<uc_CongratulationCard, CongratulationCardDto>().ForMember(dest=>dest.Gifts, opc=>opc.MapFrom(src=>src.uc_Gift)).ForMember(dest => dest.Photos, opc => opc.MapFrom(src=>src.uc_Photo)).ForMember(dest => dest.Congratulations, opc => opc.MapFrom(src=>src.uc_Congratulation)).ForMember(dest => dest.User, opc => opc.MapFrom(src => src.uc_User));
        cfg.CreateMap<uc_User, UserDto>().ForMember(dest => dest.CongratulationCards, opc => opc.MapFrom(src => src.uc_CongratulationCard)).MaxDepth(3);
      });
      Mapper.AssertConfigurationIsValid();

      var res =Mapper.Map<IEnumerable<uc_User>, List<UserDto>>(users);
      return res;
    }

    public UserDto GetUser(int? id)
    {
      UserDto res = null;
      if (id == null)
      {
        throw new ArgumentException("id не может быть null");
      }
      var user = db.UserRepository.Get(id.Value);
      if (user == null)
      {
        throw new Exception("Пользхователь не найден");
      }
      else
      {
        Mapper.Initialize(cfg =>
        {
          cfg.CreateMap<uc_Photo, PhotoDto>().ForMember(dest => dest.CongratulationCard, opc => opc.MapFrom(src => src.uc_CongratulationCard));
          cfg.CreateMap<uc_Gift, GiftDto>().ForMember(dest => dest.CongratulationCards, opc => opc.MapFrom(src => src.uc_CongratulationCard));
          cfg.CreateMap<uc_Congratulation, CongratulationDto>();
          cfg.CreateMap<uc_CongratulationCard, CongratulationCardDto>().ForMember(dest => dest.Gifts, opc => opc.MapFrom(src => src.uc_Gift)).ForMember(dest => dest.Photos, opc => opc.MapFrom(src => src.uc_Photo)).ForMember(dest => dest.Congratulations, opc => opc.MapFrom(src => src.uc_Congratulation)).ForMember(dest => dest.User, opc => opc.MapFrom(src => src.uc_User));
          cfg.CreateMap<uc_User, UserDto>().ForMember(dest => dest.CongratulationCards, opc => opc.MapFrom(src => src.uc_CongratulationCard)).MaxDepth(3);
        });
        Mapper.AssertConfigurationIsValid();
        res = Mapper.Map<uc_User, UserDto>(user);
      }
      return res;
    }
  }
}