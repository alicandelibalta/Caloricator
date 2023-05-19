using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caloricator.Model.Concrete
{
    public class User
    {
        int UserId { get; set; }
        string UserName { get; set; }
        string UserSurname {get; set; }
        string Password { get; set; }
        string Email { get; set; }
       
    }
}
