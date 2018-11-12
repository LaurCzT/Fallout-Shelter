namespace Shelter
{
    public static class Options
    {
        // Cheat
        public static bool Watermark = true;

        // Visual
        public static bool DwellerESP = false;

        // Dweller Options
        public static bool AlwaysHappy = false;
        public static bool SetDwellerHappiness = false;
        public static int DwellerHappinessMultiplier = 1;

        public static bool SetDwellerMaxHealth = false;
        public static bool SetBiggerCriticalHitMeter = false;
        public static bool SetHigherCriticalHit = false;

        public static bool EnableSpeedDwellers = false;
        public static bool SetDwellerRunningSpeed = false;
        public static bool SetDwellerWalkingSpeed = false;
        public static float RunningSpeedMultiplier = 1f;
        public static float WalkingSpeedMultiplier = 1f;


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
