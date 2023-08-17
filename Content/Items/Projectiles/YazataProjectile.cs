using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IOE.Content.Items.Projectiles
{
    internal class YazataProjectile : ModProjectile
    {



        public override void SetDefaults()
        {
            // This method right here is the backbone of what we're doing here; by using this method, we copy all of
            // the Meowmere Projectile's SetDefault stats (such as projectile.friendly and projectile.penetrate) on to our projectile,
            // so we don't have to go into the source and copy the stats ourselves. It saves a lot of time and looks much cleaner;
            // if you're going to copy the stats of a projectile, use CloneDefaults().

            Projectile.CloneDefaults(ProjectileID.MagicDagger);

            // To further the Cloning process, we can also copy the ai of any given projectile using AIType, since we want
            // the projectile to essentially behave the same way as the vanilla projectile.
            AIType = ProjectileID.MagicDagger;

            // After CloneDefaults has been called, we can now modify the stats to our wishes, or keep them as they are.
            // For the sake of example, lets make our projectile penetrate enemies a few more times than the vanilla projectile.
            // This can be done by modifying projectile.penetrate
            Projectile.penetrate += 3;
        }



        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            // Apply debuffs to the hit NPC
            target.AddBuff(BuffID.Slow, 720); // Apply 'On Fire!' debuff for 60 frames (1 second)
            target.AddBuff(BuffID.Poisoned, 720); // Apply 'Poisoned' debuff for 120 frames (2 seconds)

            base.OnHitNPC(target, hit, damageDone);
        }

        public override void SetStaticDefaults()
        {

            base.SetStaticDefaults();
        }
    }
}
