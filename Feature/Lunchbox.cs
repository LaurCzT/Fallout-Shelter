namespace Shelter
{
    public class Lunchbox
    {
        /// <summary>
        /// Adding one regular lunchbox
        /// </summary>
        public static void AddLunchBox(int amount)
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.AddLunchBox(ELunchBoxType.Regular, amount);
            }
        }

        /// <summary>
        /// Adding Mr. Handy LunchBox
        /// </summary>
        public static void AddLunchBoxMrHandy(int amount)
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.AddLunchBox(ELunchBoxType.MrHandy, amount);
            }
        }

        /// <summary>
        /// Adding Pet Carrier Lunchbox
        /// </summary>
        public static void AddLunchBoxPet(int amount)
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.AddLunchBox(ELunchBoxType.PetCarrier, amount);
            }
        }

        /// <summary>
        /// Adding one Lunchbox Starterpack
        /// </summary>
        public static void AddLunchBoxStarter(int amount)
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.AddLunchBox(ELunchBoxType.StarterPack, amount);
            }
        }
    }
}
