using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Bear : Character
    {
        public static int Attack = 20;
        public  int Health = 300;
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {   
                ApplyDamage(ref Player.Attack, ref Health);
                (anotherActor as Player).Health -= Attack;
            }
            
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I am done...");
        }

        public override int DefaultSpriteId => 124;
        public override string DefaultName => "Bear";
    }
    
}