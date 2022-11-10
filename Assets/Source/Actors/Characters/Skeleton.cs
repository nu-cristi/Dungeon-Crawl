using System;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Skeleton : Character
    {
        public static int Attack = 2;
        public int Health = 20;

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                if (Health > 0)
                {
                    ApplyDamage(ref Player.Attack, ref Health);
                    (anotherActor as Player).Health -= Attack;
                }
                else
                {
                    SetSprite(719);
                    return true;
                }
            }
            return false;
        }

        // protected override void OnUpdate(float deltaTime)
        // {
        //     var rd = new System.Random();
        //     int randNum = rd.Next(1, 5);
        //     switch (randNum)
        //     {
        //         case 1:
        //             TryMove(Direction.Up);
        //             break;
        //         case 2:
        //             TryMove(Direction.Right);
        //             break;
        //         case 3:
        //             TryMove(Direction.Left);
        //             break;
        //         case 4:
        //             TryMove(Direction.Down);
        //             break;
        //         default:
        //             throw new ArgumentOutOfRangeException(nameof(Direction), randNum, null);
        //     }
        // }

        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }
        

        public override int DefaultSpriteId => 316;
        public override string DefaultName => "Skeleton";
    }
}
