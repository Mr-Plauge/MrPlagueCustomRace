//make sure to add "modReferences = MrPlagueRaces" into your mod's Build.txt
using Terraria.ModLoader;

namespace MrPlagueCustomRace
{
    public class MrPlagueCustomRace : Mod
    {
        public static MrPlagueCustomRace Instance { get; private set; }
        public override void Load()
        {
            //this is essential, loads this mod's custom races
            MrPlagueRaces.Core.Loadables.LoadableManager.Autoload(this);
        }
        public override void Unload()
        {
            //this is essential, unloads this mod's custom races
            MrPlagueRaces.Common.Races.RaceLoader.Races.Clear();
            MrPlagueRaces.Common.Races.RaceLoader.RacesByLegacyIds.Clear();
            MrPlagueRaces.Common.Races.RaceLoader.RacesByFullNames.Clear();
        }
    }
}