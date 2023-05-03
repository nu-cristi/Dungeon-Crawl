using System;
using DungeonCrawl.Core;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Skeleton : Character
    {
        public static int Attack = 2;
        public int Health = 20;
        public override int DefaultSpriteId => 316;
        public override string DefaultName => "Skeleton";
        
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
                    ActorManager.Singleton.DestroyAllActors();
                    MapLoader.LoadMap(3);
                }
                if (Health > 0)
                {
                    ApplyDamage(ref Player.Attack, ref Health);
                }
                else
                {
                    SetSprite(719);
                    return true;
                }
            }
            return false;
        }

        protected override void OnUpdate(float deltaTime)
        {
            _elapsed += Time.deltaTime;
            if (Health > 0)
            {
                if (_elapsed >= 0.8f)
                {
                    var rd = new System.Random();
                    int randNum = rd.Next(1, 5);
                    _elapsed %= 0.8f;
                    
                    switch (randNum)
                    {
                        case 1:
                            TryMove(Direction.Up);
                            break;
                        case 2:
                            TryMove(Direction.Right);
                            break;
                        case 3:
                            TryMove(Direction.Left);
                            break;
                        case 4:
                            TryMove(Direction.Down);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(Direction), randNum, null);
                    }
                }
            }
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }
    }
}
