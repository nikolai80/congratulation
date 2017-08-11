using System.Collections.Generic;

namespace congratulation.BLL
{
  public class GiftDto
  {
    public int Id { get; set; }
    public string GiftImage { get; set; }

    public virtual ICollection<CongratulationCardDto> CongratulationCards { get; set; }
  }
}