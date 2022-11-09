namespace DungeonCrawl.Actors.Static
{
    public class Trees :Actor
    {
        public override int DefaultSpriteId => 50;
        public override string DefaultName => "Trees";

        public override bool Detectable => true;
    }
}