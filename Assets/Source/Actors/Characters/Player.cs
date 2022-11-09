using System.Collections.Generic;
using System.Text;
using Assets.Source.Core;
using DungeonCrawl.Actors.Static;
using DungeonCrawl.Core;
using UnityEditor;
using UnityEngine;


namespace DungeonCrawl.Actors.Characters
{
    public class Player : Character
    {
        public List<Item> Inventory = new List<Item>();
        
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
                var item = ActorManager.Singleton.GetActorAt<Item>(this.Position);
                if (item != null)
                {
                    UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomLeft);
                    if (item is Weapon || item is Key || item is Health)
                    {
                        ActorManager.Singleton.DestroyActor(item);
                    }

                    Inventory.Add(item);
                    
                    UserInterface.Singleton.SetText(Inventory.ToString(), UserInterface.TextPosition.TopLeft);

                }
                
            }   
        }
        
        public  override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Your inventory:\n");
            foreach (var item in Inventory)
            {
                sb.Append($"1 - {item.DefaultName}");
            }

            return sb.ToString();
        }
        
        
        
        protected override void OnDeath()
        {
            Debug.Log("Oh no, I'm dead!");
        }

        public override int DefaultSpriteId => 24;
        public override string DefaultName => "Player";
    }
}
