using PlayerStats.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStats.Controller
{
        
    class PlayerController
    {
        public List<Player> GetPlayers()
        {
            using (PlayerDBEntities a = new PlayerDBEntities())

            {
                return a.Players.ToList();
            }
        }
            public void CreatePlayer(Player d)
            {
                using (PlayerDBEntities db = new PlayerDBEntities())
                {
                    var lastPlayer = db.Players.ToList().LastOrDefault();
                    if (lastPlayer == null)
                    {
                        lastPlayer = new Player();
                        lastPlayer.Id = 0;
                    }

                    d.Id = lastPlayer.Id + 1;
                    db.Players.Add(d);
                    db.SaveChanges();
            }
        }
    }
}
