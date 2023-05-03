using Assets.Source.Core;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using UnityEngine;


namespace DungeonCrawl.Actors.Static
{
    public abstract class Item : Actor
    {
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {   
                UserInterface.Singleton.SetText($"Press E to\npick up {DefaultName}", UserInterface.TextPosition.BottomLeft);
                
                // ActorManager.Singleton.DestroyActor(this);
            }
            return true;
        }
    }
}