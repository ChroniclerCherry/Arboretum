using StardewModdingAPI;

namespace Arboretum
{
    /// <summary>Mod entry point.</summary>
    public class ModEntry : Mod
    {
        /// <summary>Mod entry point.</summary>
        /// <param name="helper">Provides methods for interacting with the mod directory as well as the modding api.</param>
        public override void Entry(IModHelper helper)
        {
            Monitor.Log("Arboretum loaded");
        }
    }
}
