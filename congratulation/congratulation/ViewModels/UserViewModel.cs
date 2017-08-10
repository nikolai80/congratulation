using congratulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.ViewModels
{
  public class UserViewModel
  {
    public int Id { get; set; }
    public string Alias { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public System.DateTime BirthdayDate { get; set; }
    public virtual ICollection<uc_Congratulation> uc_CongratulationCards { get; set; }
  }
}