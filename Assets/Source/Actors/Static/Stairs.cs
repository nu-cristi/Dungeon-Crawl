namespace DungeonCrawl.Actors.Static
{
    public class Stairs : Actor
    {
        public override int DefaultSpriteId => 289;
        public override string DefaultName => "Stairs";

        public override bool Detectable => true;
        public override bool OnCollision(Actor anotherActor)
        {
            // All actors are passable by default
            return true;
        }
    }
}