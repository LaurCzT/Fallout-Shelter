using UnityEngine;
using Shelter.DwellerOpt;
using Shelter.EventOpt;
using Shelter.InventoryOpt;
using Shelter.VaultOpt;
using Shelter.LunchBoxOpt;
using Shelter.CheatOpt;

namespace Shelter
{
    public class Loader
    {
        public static GameObject loadObject;

        public static void Load()
        {
            loadObject = new GameObject();

            // Main
            loadObject.AddComponent<Menu>();
            loadObject.AddComponent<CheatOptions>();

            // Options
            loadObject.AddComponent<DwellerOptions>();
            loadObject.AddComponent<EventOptions>();
            loadObject.AddComponent<InventoryOptions>();
            loadObject.AddComponent<VaultOptions>();
            loadObject.AddComponent<LunchboxOptions>();

            Object.DontDestroyOnLoad(loadObject);
        }

        public static void Unload()
        {
            UnloadCheat();
        }

        public static void UnloadCheat()
        {
            Object.Destroy(loadObject);
        }
    }
}
