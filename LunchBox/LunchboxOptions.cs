using UnityEngine;

namespace Shelter.LunchBoxOpt
{
    public class LunchboxOptions : MonoBehaviour
    {
        /// <summary>
        /// Adding one regular lunchbox
        /// </summary>
        public static void AddLunchBox()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.AddLunchBox(ELunchBoxType.Regular, 1);
            }
        }

        /// <summary>
        /// Adding Mr. Handy LunchBox
        /// </summary>
        public static void AddLunchBoxMrHandy()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.AddLunchBox(ELunchBoxType.MrHandy, 1);
            }
        }

        /// <summary>
        /// Adding Pet Carrier Lunchbox
        /// </summary>
        public static void AddLunchBoxPet()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.AddLunchBox(ELunchBoxType.PetCarrier, 1);
            }
        }

        /// <summary>
        /// Adding one Lunchbox Starterpack
        /// </summary>
        public static void AddLunchBoxStarter()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.AddLunchBox(ELunchBoxType.StarterPack, 1);
            }
        }
    }
}
