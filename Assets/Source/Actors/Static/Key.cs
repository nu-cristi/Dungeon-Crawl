namespace DungeonCrawl.Actors.Static
{
    public class Key : Item
    {
        public override int DefaultSpriteId => 560;
        public override string DefaultName => "Key";

        public override bool Detectable => true;
    }
}