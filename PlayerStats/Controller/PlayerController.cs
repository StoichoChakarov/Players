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
            using(PlayerDBEntities a = new PlayerDBEntities())

            {
                return a.Players.ToList();
            }
        }
    }
}
