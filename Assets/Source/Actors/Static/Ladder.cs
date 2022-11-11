using Assets.Source.Core;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;

namespace DungeonCrawl.Actors.Static
{
    public class Ladder : Actor
    {
        public override int DefaultSpriteId => 290;
        public override string DefaultName => "Ladder";
        public override bool Detectable => true;
        
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {   
                UserInterface.Singleton.SetText($"Level 2", UserInterface.TextPosition.BottomLeft);
                ActorManager.Singleton.DestroyAllActorsExceptPlayer();
                MapLoader.LoadMap(2);
            }
            return true;
        }
    }
}