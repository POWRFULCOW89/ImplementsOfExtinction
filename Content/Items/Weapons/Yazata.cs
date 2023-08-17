using IOE.Content.Items.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IOE.Content.Items.Weapons
{
    public class Yazata : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.IOE.hjson file.

        //Yazata will be a throwing dagger that will use 12 mana per throw, on hit it will deal poison and slow debuff.

        //Base Damage: 40 DONE
        //Mana Usage: 12 per use
        //Critical Chance: 6% DONE
        //Use Time: 10 DONE
        //Velocity: 16 DONE 

        public override void SetDefaults()
        {
            Item.damage = 40;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 1;
            Item.useAnimation = 1;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            //Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<YazataProjectile>();
            Item.shootSpeed = 16f;
            Item.crit = 6;
            Item.mana = 12;
            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}