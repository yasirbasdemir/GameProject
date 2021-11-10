using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerMenager : IGamerService
    {
        IUserVerificationService _userVerificationService;

        public GamerMenager(IUserVerificationService userVerificationService)
        {
            _userVerificationService = userVerificationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userVerificationService.Verification(gamer))
            {
                Console.WriteLine("Oyuncunun kayıdı başarılı olmuştur.");
            }
            else
            {
                Console.WriteLine("Oyucu kayıdı başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + "Oyuncunun kayıdı silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + "Oyuncu bilgileri güncellendi.");
        }
    }
}
