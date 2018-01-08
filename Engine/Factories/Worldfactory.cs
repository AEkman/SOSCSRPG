using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0, "Hemma", "Du är hemma!", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/home.jpg");
            newWorld.AddLocation(0, -1, "Hallen", "Du är i hallen", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/hallway.jpg");
            newWorld.AddLocation(-1, -1, "Toaletten", "Du är i toaletten", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/toilet.jpg");
            newWorld.AddLocation(0, -2, "Vardagsrum", "Du är i vardagsrummet", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/livingroom.jpg");
            newWorld.AddLocation(0, -3, "Sovrummet", "Du är i sovrummet", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/bedroom.jpg");
            newWorld.AddLocation(-1, -2, "Balkongen", "Du är ute på balkongen", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/balcony.jpg");
            newWorld.AddLocation(1, -2, "Kök", "Du är i på köket", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/kitchen.jpg");

            newWorld.AddLocation(0, 1, "Ut", "Du är utomhus", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/outside.jpg");
            newWorld.AddLocation(0, 2, "Väg", "Du är ute på en väg", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/outside.jpg");
            newWorld.AddLocation(0, 3, "Arken Zoo", "Du är ute i himmelriket på Arken Zoo", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/dogshop.jpg");
            newWorld.AddLocation(1, 2, "Snowie", "Du är hemma hos Snowie", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/snowie.png");
            newWorld.AddLocation(-1, 2, "Maya", "Du är hemma hos Maya", "C:/C#/SOSCSRPG/Engine/Models/Images/Locations/maya.jpg");
            return newWorld;
        }
    }
}