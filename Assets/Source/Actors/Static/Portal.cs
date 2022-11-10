namespace DungeonCrawl.Actors.Static
{
    public class Portal : Actor
    {
        public override int DefaultSpriteId => 432;
        public override string DefaultName => "Portal";
        public override bool Detectable => true;
        
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}