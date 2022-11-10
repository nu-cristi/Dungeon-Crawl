using System;
using DungeonCrawl.Core;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Ciclop : Character
    {
        public static int Attack = 30;
        public int Health = 100;
        
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                if ((anotherActor as Player).Health > 0)
                {
                    (anotherActor as Player).Health -= Attack;
                }
                else
                {
                    Debug.Log("intra???");
                    ActorManager.Singleton.DestroyAllActors();
                    MapLoader.LoadMap(3);
                }

                if (Health > 0)
                {
                    ApplyDamage(ref Player.Attack, ref Health);
                    
                }
                else
                {
                    SetSprite(713);
                    return true;
                }

            }
            return false;
        }
        

        
        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }

        public override int DefaultSpriteId => 455;
        public override string DefaultName => "Ciclop";
    }
}