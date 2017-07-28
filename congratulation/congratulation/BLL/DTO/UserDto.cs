using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.BLL.DTO
{
  public class UserDto
  {

    public int Id { get; set; }
    public string Alias { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public System.DateTime BirthdayDate { get; set; }
    public virtual ICollection<uc_CongratulationCard> uc_CongratulationCard { get; set; }
  }
}