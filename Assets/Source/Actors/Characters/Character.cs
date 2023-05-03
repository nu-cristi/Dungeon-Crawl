using DungeonCrawl.Core; 

namespace DungeonCrawl.Actors.Characters
{
    public abstract class Character : Actor
    {
        protected float _elapsed = 0f;
        public override int Z => -1;
        
        public void ApplyDamage(ref int damage, ref int health)
        {
            if (health > 0)
            {
                health -= damage;
            }
            else
            {
                // Die
                OnDeath();
                // ActorManager.Singleton.DestroyActor(this);
            }
        }

        protected abstract void OnDeath();
    }
}
