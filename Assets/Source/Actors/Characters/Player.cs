using Assets.Source.Core;
using DungeonCrawl.Actors.Static;
using DungeonCrawl.Core;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Player : Character
    {
        private Health _health = new Health();
        
        
        protected override void OnUpdate(float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                // Move up
                UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomLeft);
                TryMove(Direction.Up);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                // Move down
                UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomLeft);
                TryMove(Direction.Down);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                // Move left
                UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomLeft);
                TryMove(Direction.Left);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                // Move right
                UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomLeft);
                TryMove(Direction.Right);
            }   
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomLeft);
                OnCollision(this);
            }   
        }
        
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {   
                UserInterface.Singleton.SetText("Press E to pick up item", UserInterface.TextPosition.BottomLeft);
                ActorManager.Singleton.DestroyActor(_health);
            }
            return true;
        }
        
        
        protected override void OnDeath()
        {
            Debug.Log("Oh no, I'm dead!");
        }

        public override int DefaultSpriteId => 24;
        public override string DefaultName => "Player";
    }
}
