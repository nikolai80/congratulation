using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using congratulation.Models;

namespace congratulation.Dal
{
  public interface IUnitOfWork:IDisposable
  {
    IRepository<uc_User> UserRepository { get; }
    IRepository<uc_CongratulationCard> CongratulationCardRepository { get; }
    IRepository<uc_Congratulation> CongratulationRepository { get; }
    IRepository<uc_Gift> GiftRepository { get; }
    IRepository<uc_Photo> PhotoRepository { get; }
    void Save();
  }
}
