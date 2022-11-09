using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Skeleton : Character
    {
        public static int Attack = 2;
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {   
                ApplyDamage(Player.Attack);
            }
            
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }

        public override int DefaultSpriteId => 316;
        public override string DefaultName => "Skeleton";
    }
}
