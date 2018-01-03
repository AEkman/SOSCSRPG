using Engine.Models;
using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Atlas";
            CurrentPlayer.Class = "Dog";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            //CurrentLocation = CurrentWorld.LocationAt(0, -1);
            //CurrentLocation = CurrentWorld.LocationAt(0, 1);
            CurrentLocation = CurrentWorld.LocationAt(1, 0);
        }
    }
}
