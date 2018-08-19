using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        private Player CurrentPlayer { get; set; }

        public GameSession()
        {

            // Refactored for readability from the tutorial version by removing all
            // of the CurrentPlayer.Properties
            CurrentPlayer = new Player
            {
                Name = "Scott",
                CharacterClass = "Fighter",
                HitPoints = 10,
                Gold = 100000,
                ExperiencePoints = 0,
                Level = 1
            };
        }
    }
}