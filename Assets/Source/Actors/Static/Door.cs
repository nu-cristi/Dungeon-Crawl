using DungeonCrawl.Actors.Characters;

namespace DungeonCrawl.Actors.Static
{
    public class Door : Actor
    {
        public override int DefaultSpriteId => 431;
        public override string DefaultName => "Door";

        public override bool Detectable => true;
        
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
                foreach (var item in (anotherActor as Player).Inventory)
                {
                    if (item is Key)
                    {
                        SetSprite(432);
                        (anotherActor as Player).Inventory.Remove(item);
                        return true;
                    }
                }
            return false;
        }
    }
}