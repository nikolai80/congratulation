using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congratulation.BLL.Services
{
  interface ICongratulationCardService
  {
    void AddCard(CongratulationCardDto card);
    void EditCard(CongratulationCardDto card);
    void Dispose();
  }
}
