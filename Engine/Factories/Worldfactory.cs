using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            //newWorld.AddLocation(0, -1, "Home", "This is your home", "/Engine;component/Images/Locations/home.png");
            newWorld.AddLocation(0, -1, "Home", "This is your home", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/home.png");
            newWorld.AddLocation(0, 1, "Snowies hem", "Du är hemma hos din kompis Snowie.", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/snowie.png");
            newWorld.AddLocation(1, 0, "Mayas Hem", "Du är hemma hos din kompis Maya.", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/backyard.jpg");
            return newWorld;
        }
    }
}
