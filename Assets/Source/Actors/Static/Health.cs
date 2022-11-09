using Assets.Source.Core;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using UnityEngine;

namespace DungeonCrawl.Actors.Static
{
    public class Health : Actor
    {
        public override int DefaultSpriteId => 801;
        public override string DefaultName => "Health";
        public override bool Detectable => true;
        
        

        
      
        // public override bool OnCollision(Actor anotherActor)
        // {
        //     if (anotherActor is Player)
        //     {   
        //         UserInterface.Singleton.SetText("Press E to pick up item", UserInterface.TextPosition.BottomLeft);
        //         ActorManager.Singleton.DestroyActor(this);
        //     }
        //     return true;
        // }
    }
}   