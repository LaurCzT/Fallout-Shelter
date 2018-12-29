namespace Shelter
{
    public class CDweller
    {
        /// <summary>
        /// Set the Dwellers to be always happy
        /// </summary>
        public static void AlwaysHappy()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Setting.AlwaysHappy)
            {
                for (int i = 0; i < MonoSingleton<DwellerManager>.Instance.Dwellers.Count; i++)
                {
                    Dweller person = MonoSingleton<DwellerManager>.Instance.Dwellers[i];
                    person.Happiness.AddHappiness(1000);
                }
            }
        }

        /// <summary>
        /// Level up all of the dwellers in the vault
        /// </summary>
        public static void LevelUpAllDwellers()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                for (int i = 0; i < MonoSingleton<DwellerManager>.Instance.Dwellers.Count; i++)
                {
                    Dweller person = MonoSingleton<DwellerManager>.Instance.Dwellers[i];
                    person.Experience.LevelUP();
                }
            }
        }

        /// <summary>
        /// Set every dweller in the vault to max "S.P.E.C.I.A.L"
        /// </summary>
        public static void EveryDwellerIsSpecial()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                for (int i = 0; i < MonoSingleton<DwellerManager>.Instance.Dwellers.Count; i++)
                {
                    Dweller person = MonoSingleton<DwellerManager>.Instance.Dwellers[i];
                    person.Stats.GetStat(ESpecialStat.Agility).IncreaseBaseValue(100);
                    person.Stats.GetStat(ESpecialStat.Charisma).IncreaseBaseValue(100);
                    person.Stats.GetStat(ESpecialStat.Endurance).IncreaseBaseValue(100);
                    person.Stats.GetStat(ESpecialStat.Intelligence).IncreaseBaseValue(100);
                    person.Stats.GetStat(ESpecialStat.Luck).IncreaseBaseValue(100);
                    person.Stats.GetStat(ESpecialStat.Perception).IncreaseBaseValue(100);
                    person.Stats.GetStat(ESpecialStat.Strength).IncreaseBaseValue(100);
                }
            }
        }

        /// <summary>
        /// Make every weoman in the vault pregnant
        /// </summary>
        public static void EveryWomanIsPregnant()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                for (int i = 0; i < MonoSingleton<DwellerManager>.Instance.Dwellers.Count; i++)
                {
                    Dweller woman = MonoSingleton<DwellerManager>.Instance.Dwellers[i];
                    woman.SetPregnant(true);
                }
            }
        }

        /// <summary>
        /// Give every pregnant woman an abortion
        /// </summary>
        public static void EveryWomanIsNotPregnant()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                for (int i = 0; i < MonoSingleton<DwellerManager>.Instance.Dwellers.Count; i++)
                {
                    Dweller woman = MonoSingleton<DwellerManager>.Instance.Dwellers[i];
                    woman.SetPregnant(false);
                }
            }
        }

        /// <summary>
        /// Spawn an Common dweller outside the vault
        /// </summary>
        public static void SpawnCommonDweller()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                MonoSingleton<DwellerSpawner>.Instance.CreateWaitingDweller(EGender.Any, false, 0, EDwellerRarity.Common);
            }
        }

        /// <summary>
        /// Spawn an Normal dweller outside the vault
        /// </summary>
        public static void SpawnNormalDweller()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                MonoSingleton<DwellerSpawner>.Instance.CreateWaitingDweller(EGender.Any, false, 0, EDwellerRarity.Normal);
            }
        }

        /// <summary>
        /// Spawn an Rare dweller outside the vault
        /// </summary>
        public static void SpawnRareDweller()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                MonoSingleton<DwellerSpawner>.Instance.CreateWaitingDweller(EGender.Any, false, 0, EDwellerRarity.Rare);
            }
        }

        /// <summary>
        /// Spawn an Legendary dweller outside the vault
        /// </summary>
        public static void SpawnLegendaryDweller()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                MonoSingleton<DwellerSpawner>.Instance.CreateWaitingDweller(EGender.Any, false, 0, EDwellerRarity.Legendary);
            }
        }

        /// <summary>
        /// Sets our dwellers to max health
        /// </summary>
        public static void DwellersMaxHealth()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Setting.SetDwellerMaxHealth)
            {
                for (int i = 0; i < MonoSingleton<DwellerManager>.Instance.Dwellers.Count; i++)
                {
                    Dweller person = MonoSingleton<DwellerManager>.Instance.Dwellers[i];
                    person.ChangeHealth(person.Health.HealthMax);
                }
            }
        }

        /// <summary>
        /// Increase the critical hit meter
        /// </summary>
        public static void BiggerCriticalHitMeter()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Setting.SetBiggerCriticalHitMeter)
            {
                for (int i = 0; i < MonoSingleton<DwellerManager>.Instance.Dwellers.Count; i++)
                {
                    Dweller person = MonoSingleton<DwellerManager>.Instance.Dwellers[i];
                    person.IncreaseCriticalHitMeter();
                }
            }
        }

        /// <summary>
        /// Sets Dweller critical hit to 5000
        /// </summary>
         public static void HigherCriticalHit()
         {
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Setting.SetHigherCriticalHit)
            {
                for (int i = 0; i < MonoSingleton<DwellerManager>.Instance.Dwellers.Count; i++)
                {
                    Dweller person = MonoSingleton<DwellerManager>.Instance.Dwellers[i];
                    person.PerformCriticalHit(5000);
                }
            }
         }

    }
}
