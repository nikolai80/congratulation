namespace congratulation.BLL
{
  public class PhotoDto
  {
    public int Id { get; set; }
    public string PhotoUrl { get; set; }

    public virtual CongratulationCardDto CongratulationCard { get; set; }
  }
}