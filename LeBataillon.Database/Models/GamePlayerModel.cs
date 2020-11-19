using System.Collections.Generic;

namespace LeBataillon.Database.Models
{
    public class GamePlayerModel
    {
        public GamePlayerModel()
        {

        }

        public GamePlayerModel(List<Game> GameList, List<Player> PlayerList)
        {
            this.GameList = GameList;
            this.PlayerList = PlayerList;
        }



        public List<Game> GameList { get; set; }
        public List<Player> PlayerList { get; set; }
    }
}