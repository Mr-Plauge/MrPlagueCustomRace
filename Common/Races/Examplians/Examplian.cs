//make sure to add "modReferences = MrPlagueRaces" into your mod's Build.txt
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using MrPlagueRaces.Common.Races;
using MrPlagueCustomRace.Sounds;

//this is a custom race file. It contains the code that makes up the race
namespace MrPlagueCustomRace.Common.Races.Examplians
{
	public class Examplian : Race
	{
        //display name, used to override the race's displayed name. By default, a race will use its class name
        public override string RaceDisplayName => "Examplian";
        //decides if the race has a custom hurt sound (prevents default hurt sound from playing)
        public override bool UsesCustomHurtSound => true;
        //decides if the race has a custom death sound (prevents default death sound from playing)
        public override bool UsesCustomDeathSound => true;
		//decides if the race has a custom female hurt sound (by default, the race will play the male/default hurt sound for both genders)
        public override bool HasFemaleHurtSound => true;

        //textures for the race's display background in the UI
		public override string RaceEnvironmentIcon => ($"MrPlagueCustomRace/Common/UI/RaceDisplay/Environment/Environment_CustomTest");
		public override string RaceEnvironmentOverlay1Icon => ($"MrPlagueRaces/Common/UI/RaceDisplay/Environment/EnvironmentOverlay_Meteor");
        public override string RaceEnvironmentOverlay2Icon => ($"MrPlagueRaces/Common/UI/RaceDisplay/Environment/EnvironmentOverlay_Sandstorm");

		//information for the race's textures and lore in the UI
		public override string RaceSelectIcon => ($"MrPlagueCustomRace/Common/UI/RaceDisplay/ExamplianSelect");
		public override string RaceDisplayMaleIcon => ($"MrPlagueCustomRace/Common/UI/RaceDisplay/ExamplianDisplayMale");
        public override string RaceDisplayFemaleIcon => ($"MrPlagueCustomRace/Common/UI/RaceDisplay/ExamplianDisplayFemale");
		public override string RaceLore1 => "Created solely to be" + "\nused as an example," + "\nthe Examplians are" + "\nin constant pain.";
        public override string RaceLore2 => "They are said to have originated" + "\nfrom Kenku laboratories, although" + "\nthere is no actual evidence.";
		//"\n" is normally used to move to the next line, but it conflicts with colored text so I split the ability and additional notes into several lines
		public override string RaceAbilityName => "Derpkin Noise";
		public override string RaceAbilityDescription1 => "Press [c/34EB93:Racial Ability Hotkey] to play the Derpkin Hurt noise. May destroy headphones.";
		public override string RaceAbilityDescription2 => "";
		public override string RaceAbilityDescription3 => "";
		public override string RaceAbilityDescription4 => "";
		public override string RaceAbilityDescription5 => "";
        public override string RaceAbilityDescription6 => "";
		public override string RaceAdditionalNotesDescription1 => "-Takes no knockback";
		public override string RaceAdditionalNotesDescription2 => "-Creature Spawn Rate is increased by [c/34EB93:x10]";
		public override string RaceAdditionalNotesDescription3 => "-Creature Spawn Cap is increased by [c/34EB93:+400]";
		public override string RaceAdditionalNotesDescription4 => "-Instantly dies when fully submerged in water";
		public override string RaceAdditionalNotesDescription5 => "";
        public override string RaceAdditionalNotesDescription6 => "";

		//makes the race's display background in the UI appear darker, can be used to make it look like it is night
		public override bool DarkenEnvironment => true;

		//stat info for the UI's stat display. 34EB93 is the green text, FF4F64 is the red text
		public override string RaceHealthDisplayText => "[c/34EB93:+50%]";
		public override string RaceRegenerationDisplayText => "[c/34EB93:+4]";
		public override string RaceManaDisplayText => "[c/34EB93:+50%]";
		public override string RaceManaRegenerationDisplayText => "[c/34EB93:+100]";
		public override string RaceDefenseDisplayText => "[c/34EB93:+500]";
		public override string RaceDamageReductionDisplayText => "[c/34EB93:+10%]";
		public override string RaceThornsDisplayText => "[c/34EB93:+100%]";
		public override string RaceLavaResistanceDisplayText => "[c/34EB93:+100]";
        public override string RaceMeleeDamageDisplayText => "[c/FF4F64:-100%]";
		public override string RaceRangedDamageDisplayText => "[c/FF4F64:-100%]";
		public override string RaceMagicDamageDisplayText => "[c/34EB93:+100%]";
		public override string RaceSummonDamageDisplayText => "[c/34EB93:+100%]";
		public override string RaceMeleeSpeedDisplayText => "[c/34EB93:+100%]";
		public override string RaceArmorPenetrationDisplayText => "[c/34EB93:+100]";
		public override string RaceBulletDamageDisplayText => "[c/34EB93:+30%]";
		public override string RaceRocketDamageDisplayText => "[c/34EB93:+30%]";
		public override string RaceManaCostDisplayText => "[c/FF4F64:+50%]";
		public override string RaceMinionKnockbackDisplayText => "[c/34EB93:+100%]";
		public override string RaceMinionsDisplayText => "[c/34EB93:+100]";
		public override string RaceSentriesDisplayText => "[c/34EB93:+100]";
		public override string RaceMeleeCritChanceDisplayText => "[c/34EB93:+96%]";
		public override string RaceRangedCritChanceDisplayText => "[c/34EB93:+96%]";
		public override string RaceMagicCritChanceDisplayText => "[c/34EB93:+96%]";
		public override string RaceMiningSpeedDisplayText => "[c/34EB93:+60%]";
		public override string RaceBuildingSpeedDisplayText => "[c/34EB93:+60%]";
		public override string RaceBuildingWallSpeedDisplayText => "[c/34EB93:+60%]";
        public override string RaceBuildingRangeDisplayText => "[c/34EB93:+100]";
		public override string RaceArrowDamageDisplayText => "[c/FF4F64:-100%]";
		public override string RaceMovementSpeedDisplayText => "[c/34EB93:+50%]";
		public override string RaceJumpSpeedDisplayText => "[c/34EB93:+200%]";
		public override string RaceFallDamageResistanceDisplayText => "[c/34EB93:+100]";
		public override string RaceAllDamageDisplayText => "[c/FF4F64:-50%]";
		public override string RaceFishingSkillDisplayText => "[c/34EB93:+100]";
		public override string RaceAggroDisplayText => "[c/34EB93:+5]";
		public override string RaceRunSpeedDisplayText => "[c/34EB93:+10%]";
        public override string RaceRunAccelerationDisplayText => "[c/34EB93:+20%]";

		//race environment info (CURRENTLY COSMETIC)
		public override string RaceGoodBiomesDisplayText => "Corrupt Tundra, Underworld";
		public override string RaceBadBiomesDisplayText => "Underground Desert";

		//custom hurt sounds would normally be put in PreHurt, but they conflict with Godmode in other mods so I made a custom system to avoid the confliction
		public override bool PreHurt(Player player, bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
		{
			return true;
		}

        public override bool PreKill(Player player, Mod mod, double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
			//death sound
			var MrPlagueCustomRace = ModLoader.GetMod("MrPlagueCustomRace");
			Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, MrPlagueCustomRace.GetSoundSlot(SoundType.Custom, "Sounds/Examplian_Killed"));
            return true;
        }

		public override void Load(Player player)
		{
			//if your custom race has increased health, it should also be added here (the player first joins in with vanilla health by default regardless of what their max health is). Does not need to be done with decreased health
			var modPlayer = player.GetModPlayer<MrPlagueRaces.MrPlagueRacesPlayer>();
			if (modPlayer.RaceStats)
			{
				player.statLife += 50;
			}
		}

		//things that affect the player's stats should be put in ResetEffects
        public override void ResetEffects(Player player)
        {
            //RaceStats is a bool in MrPlagueRaces that decides whether the player's racial changes are enabled or not. Make sure to put gameplay-affecting racial changes in an 'if statement' that detects if RaceStats is true
            var modPlayer = player.GetModPlayer<MrPlagueRaces.MrPlagueRacesPlayer>();
            if (modPlayer.RaceStats)
            {
                player.statLifeMax2 += (player.statLifeMax2 / 2);
                player.lifeRegen += 4;
                player.statManaMax2 += (player.statManaMax2 / 2);
                player.manaRegenBonus += 100;
                player.statDefense += 500;
                player.endurance += 0.1f;
                player.thorns += 10f;
                player.lavaMax += 100;
                player.meleeDamage -= 1f;
                player.rangedDamage -= 1f;
                player.magicDamage += 1f;
                player.minionDamage += 1f;
                player.meleeSpeed += 100f;
                player.armorPenetration += 100;
                player.bulletDamage += 0.3f;
                player.rocketDamage += 0.3f;
                player.manaCost += 0.5f;
                player.minionKB += 1f;
                player.maxMinions += 100;
                player.maxTurrets += 100;
                player.meleeCrit += 96;
                player.rangedCrit += 96;
                player.magicCrit += 96;
                player.pickSpeed -= 0.6f;
                player.tileSpeed += 0.6f;
                player.wallSpeed += 0.6f;
                player.blockRange += 100;
                player.arrowDamage -= 1f;
                player.moveSpeed += 0.5f;
                player.jumpSpeedBoost += 2f;
                player.extraFall += 100;
                player.allDamage -= 0.5f;
                player.fishingSkill += 100;
                player.aggro += 5;
                player.maxRunSpeed += 0.1f;
                player.runAcceleration += 0.2f;
                player.noKnockback = true;
			}
        }

		public override void ProcessTriggers(Player player, Mod mod)
		{
			//custom hotkey stuff goes here
			var modPlayer = player.GetModPlayer<MrPlagueRaces.MrPlagueRacesPlayer>();
			if (modPlayer.RaceStats)
			{
				if (MrPlagueRaces.MrPlagueRaces.RacialAbilityHotKey.Current && !player.dead)
				{
					Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/Derpkin_Hurt"));
				}
			}
		}

		public override void PreUpdate(Player player, Mod mod)
		{
			//hurt sounds and any additional features of the race (abilities, etc) go here
			//custom hurt sounds would normally be put in PreHurt, but they conflict with Godmode in other mods so I made a custom system to avoid the confliction
			var modPlayer = player.GetModPlayer<MrPlagueRaces.MrPlagueRacesPlayer>();
			var _MrPlagueRaces = ModLoader.GetMod("MrPlagueRaces");
			var MrPlagueCustomRace = ModLoader.GetMod("MrPlagueCustomRace");
			if (player.HasBuff(_MrPlagueRaces.BuffType("DetectHurt")) && (player.statLife != player.statLifeMax2))
			{
				if (player.Male || !HasFemaleHurtSound)
				{
					//when choosing a sound, make sure to put your mod's name before .GetSoundSlot instead of "mod". using mod will cause the program to search for the sound file in MrPlagueRace's sound folder
					Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, MrPlagueCustomRace.GetSoundSlot(SoundType.Custom, "Sounds/" + this.Name + "_Hurt"));
				}
				else if (!player.Male && HasFemaleHurtSound)
				{
					Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, MrPlagueCustomRace.GetSoundSlot(SoundType.Custom, "Sounds/" + this.Name + "_Hurt_Female"));
				}
				else
				{
					Main.PlaySound(SoundLoader.customSoundType, (int)player.Center.X, (int)player.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/Mushfolk_Hurt"));
				}
			}
            if (Collision.DrownCollision(player.position, player.width, player.height, player.gravDir))
            {
                player.KillMe(PlayerDeathReason.ByCustomReason(player.name + " dissolved."), 10.0, 0, false);
            }
		}

		public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
		{
			//editing spawn rate
			spawnRate *= (int)((double)0.1);
			maxSpawns += (int)((float)400);
		}

		public override void ModifyDrawInfo(Player player, Mod mod, ref PlayerDrawInfo drawInfo)
        {
			//custom race's default color values and clothing styles go here
            var modPlayer = player.GetModPlayer<MrPlagueRaces.MrPlagueRacesPlayer>();
            Item familiarshirt = new Item();
            familiarshirt.SetDefaults(ItemID.FamiliarShirt);
            Item familiarpants = new Item();
            familiarpants.SetDefaults(ItemID.FamiliarPants);
            if (modPlayer.resetDefaultColors)
            {
                modPlayer.resetDefaultColors = false;
                player.hairColor = new Color(90, 87, 250);
                player.skinColor = new Color(204, 204, 204);
                player.eyeColor = new Color(94, 62, 44);
				player.shirtColor = new Color(219, 70, 44);
				player.underShirtColor = new Color(170, 75, 191);
				player.pantsColor = new Color(108, 99, 110);
				player.shoeColor = new Color(40, 37, 41);
				player.skinVariant = 3;
				if (player.armor[1].type < ItemID.IronPickaxe && player.armor[2].type < ItemID.IronPickaxe)
				{
					player.armor[1] = familiarshirt;
					player.armor[2] = familiarpants;
				}
			}
		}

		public override void ModifyDrawLayers(Player player, List<PlayerLayer> layers)
		{
			//applying the racial textures
			var modPlayer = player.GetModPlayer<MrPlagueRaces.MrPlagueRacesPlayer>();

			bool hideChestplate = modPlayer.hideChestplate;
			bool hideLeggings = modPlayer.hideLeggings;

			Main.playerTextures[0, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head");
			Main.playerTextures[0, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2");
			Main.playerTextures[0, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes");
			Main.playerTextures[0, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[0, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_1");
			}
			else
			{
				Main.playerTextures[0, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[0, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[0, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_1");
			}
			else
			{
				Main.playerTextures[0, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[0, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[0, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_1");
			}
			else
			{
				Main.playerTextures[0, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[0, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand");
			Main.playerTextures[0, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[0, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_1");
				Main.playerTextures[0, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_1");
			}
			else
			{
				Main.playerTextures[0, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs");
				Main.playerTextures[0, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[0, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_1_2");
			}
			else
			{
				Main.playerTextures[0, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[0, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_1_2");
			}
			else
			{
				Main.playerTextures[0, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[1, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head");
			Main.playerTextures[1, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2");
			Main.playerTextures[1, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes");
			Main.playerTextures[1, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[1, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_2");
			}
			else
			{
				Main.playerTextures[1, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[1, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[1, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_2");
			}
			else
			{
				Main.playerTextures[1, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[1, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[1, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_2");
			}
			else
			{
				Main.playerTextures[1, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[1, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand");
			Main.playerTextures[1, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[1, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_2");
				Main.playerTextures[1, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_2");
			}
			else
			{
				Main.playerTextures[1, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs");
				Main.playerTextures[1, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[1, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_2_2");
			}
			else
			{
				Main.playerTextures[1, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[1, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_2_2");
			}
			else
			{
				Main.playerTextures[1, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[2, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head");
			Main.playerTextures[2, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2");
			Main.playerTextures[2, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes");
			Main.playerTextures[2, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[2, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_3");
			}
			else
			{
				Main.playerTextures[2, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[2, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[2, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_3");
			}
			else
			{
				Main.playerTextures[2, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[2, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[2, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_3");
			}
			else
			{
				Main.playerTextures[2, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[2, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand");
			Main.playerTextures[2, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[2, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_3");
				Main.playerTextures[2, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_3");
			}
			else
			{
				Main.playerTextures[2, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs");
				Main.playerTextures[2, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[2, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_3_2");
			}
			else
			{
				Main.playerTextures[2, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[2, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_3_2");
			}
			else
			{
				Main.playerTextures[2, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[3, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head");
			Main.playerTextures[3, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2");
			Main.playerTextures[3, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes");
			Main.playerTextures[3, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[3, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_4");
			}
			else
			{
				Main.playerTextures[3, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[3, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[3, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_4");
			}
			else
			{
				Main.playerTextures[3, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[3, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[3, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_4");
			}
			else
			{
				Main.playerTextures[3, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[3, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand");
			Main.playerTextures[3, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[3, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_4");
				Main.playerTextures[3, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_4");
			}
			else
			{
				Main.playerTextures[3, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs");
				Main.playerTextures[3, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[3, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_4_2");
			}
			else
			{
				Main.playerTextures[3, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[3, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_4_2");
			}
			else
			{
				Main.playerTextures[3, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[8, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head");
			Main.playerTextures[8, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2");
			Main.playerTextures[8, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes");
			Main.playerTextures[8, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[8, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_9");
			}
			else
			{
				Main.playerTextures[8, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[8, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[8, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_9");
			}
			else
			{
				Main.playerTextures[8, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[8, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[8, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_9");
			}
			else
			{
				Main.playerTextures[8, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[8, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand");
			Main.playerTextures[8, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[8, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_9");
				Main.playerTextures[8, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_9");
			}
			else
			{
				Main.playerTextures[8, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs");
				Main.playerTextures[8, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[8, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_9_2");
			}
			else
			{
				Main.playerTextures[8, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[8, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_9_2");
			}
			else
			{
				Main.playerTextures[8, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[4, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head_Female");
			Main.playerTextures[4, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2_Female");
			Main.playerTextures[4, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_Female");
			Main.playerTextures[4, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[4, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_5");
			}
			else
			{
				Main.playerTextures[4, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[4, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[4, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_5");
			}
			else
			{
				Main.playerTextures[4, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Body_Female");
			}

			Main.playerTextures[4, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[4, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_5");
			}
			else
			{
				Main.playerTextures[4, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[4, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand_Female");
			Main.playerTextures[4, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs_Female");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[4, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_5");
				Main.playerTextures[4, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_5");
			}
			else
			{
				Main.playerTextures[4, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs_Female");
				Main.playerTextures[4, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[4, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_5_2");
			}
			else
			{
				Main.playerTextures[4, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[4, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_5_2");
			}
			else
			{
				Main.playerTextures[4, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[5, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head_Female");
			Main.playerTextures[5, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2_Female");
			Main.playerTextures[5, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_Female");
			Main.playerTextures[5, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[5, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_6");
			}
			else
			{
				Main.playerTextures[5, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[5, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[5, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_6");
			}
			else
			{
				Main.playerTextures[5, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Body_Female");
			}

			Main.playerTextures[5, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[5, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_6");
			}
			else
			{
				Main.playerTextures[5, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[5, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand_Female");
			Main.playerTextures[5, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs_Female");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[5, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_6");
				Main.playerTextures[5, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_6");
			}
			else
			{
				Main.playerTextures[5, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs_Female");
				Main.playerTextures[5, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[5, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_6_2");
			}
			else
			{
				Main.playerTextures[5, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[5, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_6_2");
			}
			else
			{
				Main.playerTextures[5, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[6, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head_Female");
			Main.playerTextures[6, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2_Female");
			Main.playerTextures[6, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_Female");
			Main.playerTextures[6, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[6, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_7");
			}
			else
			{
				Main.playerTextures[6, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[6, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[6, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_7");
			}
			else
			{
				Main.playerTextures[6, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Body_Female");
			}

			Main.playerTextures[6, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[6, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_7");
			}
			else
			{
				Main.playerTextures[6, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[6, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand_Female");
			Main.playerTextures[6, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs_Female");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[6, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_7");
				Main.playerTextures[6, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_7");
			}
			else
			{
				Main.playerTextures[6, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs_Female");
				Main.playerTextures[6, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[6, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_7_2");
			}
			else
			{
				Main.playerTextures[6, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[6, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_7_2");
			}
			else
			{
				Main.playerTextures[6, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[7, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head_Female");
			Main.playerTextures[7, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2_Female");
			Main.playerTextures[7, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_Female");
			Main.playerTextures[7, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[7, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_8");
			}
			else
			{
				Main.playerTextures[7, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[7, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[7, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_8");
			}
			else
			{
				Main.playerTextures[7, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Body_Female");
			}

			Main.playerTextures[7, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[7, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_8");
			}
			else
			{
				Main.playerTextures[7, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[7, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand_Female");
			Main.playerTextures[7, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs_Female");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[7, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_8");
				Main.playerTextures[7, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_8");
			}
			else
			{
				Main.playerTextures[7, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs_Female");
				Main.playerTextures[7, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[7, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_8_2");
			}
			else
			{
				Main.playerTextures[7, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[7, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_8_2");
			}
			else
			{
				Main.playerTextures[7, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[9, 0] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Head_Female");
			Main.playerTextures[9, 1] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_2_Female");
			Main.playerTextures[9, 2] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Eyes_Female");
			Main.playerTextures[9, 3] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Torso_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[9, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeves_10");
			}
			else
			{
				Main.playerTextures[9, 4] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[9, 5] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hands_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[9, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shirt_10");
			}
			else
			{
				Main.playerTextures[9, 6] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Body_Female");
			}

			Main.playerTextures[9, 7] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Arm_Female");

			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[9, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_10");
			}
			else
			{
				Main.playerTextures[9, 8] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			Main.playerTextures[9, 9] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Hand_Female");
			Main.playerTextures[9, 10] = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Legs_Female");

			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[9, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_10");
				Main.playerTextures[9, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Shoes_10");
			}
			else
			{
				Main.playerTextures[9, 11] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Censor_Clothing_Legs_Female");
				Main.playerTextures[9, 12] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[1].type == ItemID.FamiliarShirt || player.armor[11].type == ItemID.FamiliarShirt) && !hideChestplate)
			{
				Main.playerTextures[9, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Sleeve_10_2");
			}
			else
			{
				Main.playerTextures[9, 13] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}
			if ((player.armor[2].type == ItemID.FamiliarPants || player.armor[12].type == ItemID.FamiliarPants) && !hideLeggings)
			{
				Main.playerTextures[9, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Pants_10_2");
			}
			else
			{
				Main.playerTextures[9, 14] = ModContent.GetTexture("MrPlagueRaces/Content/RaceTextures/Blank");
			}

			for (int i = 0; i < 133; i++)
			{
				Main.playerHairTexture[i] = ModContent.GetTexture($"MrPlagueCustomRace/Content/RaceTextures/Examplian/Hair/Examplian_Hair_{i + 1}");
				Main.playerHairAltTexture[i] = ModContent.GetTexture($"MrPlagueCustomRace/Content/RaceTextures/Examplian/Hair/Examplian_HairAlt_{i + 1}");
			}

			Main.ghostTexture = ModContent.GetTexture("MrPlagueCustomRace/Content/RaceTextures/Examplian/Examplian_Ghost");
		}
	}
}
