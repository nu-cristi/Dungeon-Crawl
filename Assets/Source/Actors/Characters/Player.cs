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
        public static int Attack = 10;
        public int Health = 30;
        private bool isTrue = false;
        protected override void OnUpdate(float deltaTime)
        {
            // UserInterface.Singleton.SetText("Press I to see Invetory\n", UserInterface.TextPosition.TopLeft);
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
                    if (item is Weapon)
                    {
                        Attack += 5;
                        ActorManager.Singleton.DestroyActor(item);
                        SetSprite(26);
                    }

                    if (item is Food)
                    {
                        Health += 100;
                        ActorManager.Singleton.DestroyActor(item);
                    }
                    else
                    {
                        ActorManager.Singleton.DestroyActor(item);
                    }

                    Inventory.Add(item);
                    UserInterface.Singleton.SetText(ToString(Inventory), UserInterface.TextPosition.TopLeft);
                    

                }
                  
            }  
            if (Input.GetKeyDown(KeyCode.I))
            {
                isTrue = !isTrue;
            }
            
            if (isTrue)
            {
                UserInterface.Singleton.SetText(ToString(Inventory), UserInterface.TextPosition.TopLeft);
                
            }
            else
            {
                UserInterface.Singleton.SetText("", UserInterface.TextPosition.TopLeft);
                
            }
        }
        
        public  string ToString(List<Item> playerList)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Health: {Health}\n");
            sb.Append($"Attack: {Attack}\n\n");
            sb.Append("Your inventory:\n");
            foreach (var item in Inventory)
            {
                sb.Append($"{item.DefaultName}:   1\n");
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
