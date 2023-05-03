using Assets.Source.Core;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using UnityEngine;

namespace DungeonCrawl.Actors.Static
{
    public class Food : Item
    {
        public override int DefaultSpriteId => 801;
        public override string DefaultName => "Cheese";
        public override bool Detectable => true;
    }
}   