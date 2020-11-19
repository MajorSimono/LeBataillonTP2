using System;
using System.Collections.Generic;
using LeBataillon.Database.Models;


namespace LeBataillon.Database.MockData
{
    public static class PlayerMockData
    {

        public static List<Player> GetPlayersTest()
        {
            var _Players = new List<Player>()
            {
                new Player()
                {
                    Id = 1,
                    NickName ="MagenAlias",
                    Email = "Magen@@bataillonMail.com",
                    PhoneNumber ="666-666-6666",
                    FirstName ="Magen",
                    LastName = "Albro",
                    Level = PlayerLevel.avancé


                },
                 new Player()
                {
                    Id = 1,
                    NickName ="MariellaAlias",
                    Email = "Mariella@@bataillonMail.com",
                    PhoneNumber ="999-999-9999",
                    FirstName ="Mariella",
                    LastName = "Loktu",
                    Level = PlayerLevel.débutant


                },
                  new Player()
                {
                    Id = 1,
                    NickName ="TonitaAlias",
                    Email = "Tonita@@bataillonMail.com",
                    PhoneNumber ="777-777-7777",
                    FirstName ="Tonita",
                    LastName = "Kalvee",
                    Level = PlayerLevel.novice


                },
                        new Player()
                {
                    Id = 1,
                    NickName ="TonitaAlias",
                    Email = "Tonita@@bataillonMail.com",
                    PhoneNumber ="777-777-7777",
                    FirstName ="Tonita",
                    LastName = "Kalvee",
                    Level = PlayerLevel.novice


                },
                         new Player()
                {
                    Id = 1,
                    NickName ="ConradAlias",
                    Email = "Conrad@@bataillonMail.com",
                    PhoneNumber ="111-111-1111",
                    FirstName ="Conrad",
                    LastName = "Siukoski",
                    Level = PlayerLevel.intermédiaire


                },
            };
            return _Players;

        }

    }
}