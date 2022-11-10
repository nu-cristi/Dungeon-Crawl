using DungeonCrawl.Core;

namespace DungeonCrawl.Actors.Characters
{
    public abstract class Character : Actor
    {
        // public int Health = 30;
        

        public void ApplyDamage(int damage, int health)
        {
            health -= damage;
            
            if (health <= 0)
            {
                // Die
                OnDeath();

                ActorManager.Singleton.DestroyActor(this);
            }
        }

        protected abstract void OnDeath();

        
        public override int Z => -1;
    }
}
