namespace DungeonCrawl.Actors.Static
{
    public class Weapon : Item
    {
        public override int DefaultSpriteId => 417;
        public override string DefaultName => "Weapon";

        public override bool Detectable => true;
    }
}