using Assets.Source.Core;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;

namespace DungeonCrawl.Actors.Static
{
    public class WinningCrown :Item
    {
        public override int DefaultSpriteId => 139;
        public override string DefaultName => "Crown";

        public override bool Detectable => true;
        public override bool OnCollision(Actor anotherActor)
        {
            ActorManager.Singleton.DestroyAllActors();
            MapLoader.LoadMap(4);
            return true;
        }
    }
}