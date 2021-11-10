using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerMenager gamerMenager = new GamerMenager(new UserVerificationMenager());
            gamerMenager.Add(new Gamer 
            { 
            FirstName = "YASİR",
            LastName = "BAŞDEMİR",
            BirthDate = 1998,
            IIentificationIumber = 74185296312,
            });

            GamerMenager gamerMenager2 = new GamerMenager(new UserVerificationMenager());
            gamerMenager2.Add(new Gamer
            {
                FirstName = "MURAT",
                LastName = "BAŞDEMİR",
                BirthDate = 1994,
                IIentificationIumber = 74185296312,  // Kimlik numarasını yanlış girdim.
            });

        }
    }
}
