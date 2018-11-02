using UnityEngine;

namespace Shelter.DwellerOpt
{
    public class DwellerOptions : MonoBehaviour
    {

        private int baseHappiness;

        /// <summary>
        /// Set the Dwellers to be always happy
        /// </summary>
        public static void AlwaysHappy()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Options.AlwaysHappy)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
                    person.Happiness.AddHappiness(1000);
                }
            }
        }

        public static void AdjustDwellerHappiness()
        {

        }

        /// <summary>
        /// Level up all of the dwellers in the vault
        /// </summary>
        public static void LevelUpAllDwellers()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
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
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
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
                foreach (Dweller woman in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
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
                foreach (Dweller woman in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
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
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Options.SetDwellerMaxHealth)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
                    person.ChangeHealth(person.Health.HealthMax);
                }
            }
        }

        /// <summary>
        /// Sets the dweller damage.
        /// </summary>
        public static void SetDwellerDamage()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
                    
                }
            }
        }

        /// <summary>
        /// Increase the critical hit meter
        /// </summary>
        public static void BiggerCriticalHitMeter()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Options.SetBiggerCriticalHitMeter)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
                    person.IncreaseCriticalHitMeter();
                }
            }
        }

        /// <summary>
        /// Sets Dweller critical hit to 5000
        /// </summary>
         public static void HigherCriticalHit()
         {
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Options.SetHigherCriticalHit)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
                    person.PerformCriticalHit(5000);
                }
            }
         }

        private float baseWalkSpeed = 1.3f;
        private float baseRunningSpeed = 4f;

        /// <summary>
        /// Starts this instance.
        /// </summary>
        private void Start()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
                    baseRunningSpeed = person.m_runningSpeed;
                    baseWalkSpeed = person.m_walkingSpeed;
                }
            }
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        private void Update()
        {
            if (MonoSingleton<DwellerManager>.IsInstanceValid && Options.EnableSpeedDwellers)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
                    if (Options.SetDwellerRunningSpeed)
                    {
                        person.m_runningSpeed = baseRunningSpeed * Options.RunningSpeedMultiplier;
                    }
                    else
                    {
                        baseRunningSpeed = person.m_runningSpeed;
                    }
                }
            }

            if (MonoSingleton<DwellerManager>.IsInstanceValid && Options.EnableSpeedDwellers)
            {
                foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                {
                    if (Options.SetDwellerWalkingSpeed)
                    {
                        person.m_walkingSpeed = baseWalkSpeed * Options.WalkingSpeedMultiplier;
                    }
                    else
                    {
                        baseWalkSpeed = person.m_walkingSpeed;
                    }
                }
            }

        }

    }
}
