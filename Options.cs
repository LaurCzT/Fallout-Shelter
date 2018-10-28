using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter
{
    public static class Options
    {
        // Cheat
        public static bool Watermark = true;

        // Dweller Options
        public static bool AlwaysHappy = false;
        public static bool SetDwellerHappiness = false;
        public static int DwellerHappinessMultiplier = 1;

        // Inventory Options
        public static bool SetVaultMaxStorage = false;

        // Event Options
        public static bool NoRandomEvent = false;

        // Vault Options
        public static bool InfiniteEnergy = false;
        public static bool InfiniteFood = false;
        public static bool InfiniteWater = false;

        public static bool AdjustDwellers = false;
        public static int MaxDwellersMultiplier = 1;
    }
}
