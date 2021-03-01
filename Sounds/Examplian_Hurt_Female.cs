//make sure to add "modReferences = MrPlagueRaces" into your mod's Build.txt
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace MrPlagueCustomRace.Sounds
{
	//female hurt sound, contains randomized pitch
	public class Examplian_Hurt_Female : ModSound
	{
		public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type) 
		{
			soundInstance = sound.CreateInstance();
			soundInstance.Pan = pan;
			soundInstance.Pitch = Main.rand.Next(-3, 1) * .05f;
			return soundInstance;
		}
	}
}
