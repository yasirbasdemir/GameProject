using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserVerificationMenager : IUserVerificationService
    {
        public bool Verification(Gamer gamer)
        {
            if (gamer.FirstName == "YASİR" && gamer.LastName == "BAŞDEMİR" && gamer.BirthDate == 1998 && gamer.IIentificationIumber == 74185296312)
            {
                return true;
            }
            else
            {
                return false;
            }
            if (gamer.FirstName == "MURAT" && gamer.LastName == "BAŞDEMİR" && gamer.BirthDate == 1994 && gamer.IIentificationIumber == 12345612345)
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
