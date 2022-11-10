using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Bear : Character
    {
        public static int Attack = 15;
        public int Health = 30;
        
        
        
        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }
        
        public override int DefaultSpriteId => 316;
        public override string DefaultName => "Skeleton";
    }
}