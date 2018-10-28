using UnityEngine;
using Shelter.DwellerOpt;
using Shelter.EventOpt;
using Shelter.InventoryOpt;
using Shelter.VaultOpt;

namespace Shelter
{
    public class Loader
    {
        public static GameObject _loadObject;

        public static void Load()
        {
            _loadObject = new GameObject();

            // All Componenets.
            _loadObject.AddComponent<Main>();
            _loadObject.AddComponent<Menu>();

            _loadObject.AddComponent<DwellerOptions>();
            _loadObject.AddComponent<EventOptions>();
            _loadObject.AddComponent<InventoryOptions>();
            _loadObject.AddComponent<VaultOptions>();


            Object.DontDestroyOnLoad(_loadObject);
        }

        public static void Unload()
        {
            _Unload();
        }

        public static void _Unload()
        {
            Object.Destroy(_loadObject);
        }
    }
}
