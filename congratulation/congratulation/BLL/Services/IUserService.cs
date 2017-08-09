using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congratulation.BLL
{
  public interface IUserService
  {

    UserDto GetUser(int? id);
    IEnumerable<UserDto> GetAllUsers();
    void Dispose();
  }
}
