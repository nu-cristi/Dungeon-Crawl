namespace DungeonCrawl.Actors.Static
{
    public class Door : Actor
    {
        public override int DefaultSpriteId => 431;
        public override string DefaultName => "Door";

        public override bool Detectable => true;
    }
}