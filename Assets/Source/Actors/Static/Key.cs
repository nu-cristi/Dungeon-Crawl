namespace DungeonCrawl.Actors.Static
{
    public class Key : Actor
    {
        public override int DefaultSpriteId => 560;
        public override string DefaultName => "Key";

        public override bool Detectable => false;
    }
}