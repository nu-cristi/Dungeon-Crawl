using DungeonCrawl.Actors.Characters;
using UnityEngine;

namespace DungeonCrawl.Actors.Static
{
    public class Portal : Actor
    {
        public override int DefaultSpriteId => 432;
        public override string DefaultName => "Portal";
            
        public override bool Detectable => true;
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                if (Input.GetKey(KeyCode.X))
                {
                    return true;
                }
            }
            return false;
        }
    }
}