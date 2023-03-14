using Verse;

namespace Multiplayer.Compat
{
    /// <summary>Kurin, The Three Tailed Fox [Deluxe Edition]</summary>
    /// <see href="https://steamcommunity.com/sharedfiles/filedetails/?id=2670355481"/>
    /// contribution to Multiplayer Compatibility by Nigecat
    [MpCompatFor("Inoshishi3.KTTFDE")]
    class KurinDeluxe
    {
        public KurinDeluxe(ModContentPack mod)
        {
            // RNG Fix
            {
                // var rngFixConstructors = new[]
                // {
                //     "AlphaBehavioursAndEvents.DeathActionWorker_ExplodeAndSpawnEggs",
                //     "AlphaBehavioursAndEvents.Hediff_Crushing",

                //     // Ocular plant conversion
                //     "AlphaBehavioursAndEvents.CompAbilityOcularConversion",
                //     "AlphaBehavioursAndEvents.Gas_Ocular",
                // };

                // PatchingUtilities.PatchSystemRandCtor(rngFixConstructors, false);

                // var rngFixMethods = new[] //System.Random fixes
                // {
                //     "AlphaBehavioursAndEvents.Hediff_Crushing:RandomFilthGenerator",

                //     // Ocular plant conversion
                //     "AlphaBehavioursAndEvents.CompAbilityOcularConversion:Apply",
                //     "AlphaBehavioursAndEvents.Gas_Ocular:Tick",
                // };
                // PatchingUtilities.PatchPushPopRand(rngFixMethods);

                // var fixSystemRngMethods = new[]
                // {
                //     "AlphaBehavioursAndEvents.Ability_SpawnOnRadius:Cast",
                //     "AlphaBehavioursAndEvents.CompCreateOcularPlants:CompTick",
                //     "AlphaBehavioursAndEvents.CompCreateOcularPlants:ConvertRandomPlantInRadius",
                // };
                // PatchingUtilities.PatchSystemRand(fixSystemRngMethods, false);
            }
        }
    }
}