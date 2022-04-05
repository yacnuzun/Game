using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirhtYear==1996 && gamer.FirstName=="Yalçın" && gamer.LastName=="Uzun" && gamer.IdentityNumaber==1234)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
