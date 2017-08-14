using congratulation.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congratulation.ViewModels
{
  public class CongratulationCardVm
  {
    public int Id { get; set; }
    public string HeaderText { get; set; }
    public string HeaderBackgroundImage { get; set; }
    public string Whom { get; set; }
    public string HeaderImageUrl { get; set; }

    public virtual UserDto User { get; set; }
    public virtual ICollection<CongratulationDto> Congratulations { get; set; }
    public virtual ICollection<GiftDto> Gifts { get; set; }
    public virtual ICollection<PhotoDto> Photos { get; set; }
  }
}