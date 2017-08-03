using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using congratulation.Models;

namespace congratulation.Dal
{
  interface IUnitOfWork
  {
    IRepository<uc_User> UserRepository { get; }
    IRepository<uc_Congratulation> CongratulationCardRepository { get; }
    IRepository<uc_Congratulation> CongratulationRepository { get; }
    IRepository<uc_Congratulation> GiftRepository { get; }
    IRepository<uc_Congratulation> PhotoRepository { get; }
    void Save();
  }
}
