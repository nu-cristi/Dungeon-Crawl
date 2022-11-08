namespace DungeonCrawl.Actors.Static
{
    public class Weapon : Actor
    {
        public override int DefaultSpriteId => 131;
        public override string DefaultName => "Door";

        public override bool Detectable => false;
    }
}