using System;
using UnityEngine;

namespace Shelter.VaultOpt
{
    public class VaultOptions : MonoBehaviour
    {
        private int baseMaxDwellers;
        /// <summary>
        /// Set the standard values of the game.
        /// </summary>
        private void GameStandardValues()
        {
            baseMaxDwellers = MonoSingleton<Vault>.Instance.MaxDwellers;
        }

        /// <summary>
        /// Adds 5000 energy to the vault
        /// </summary>
        public static void InfiniteEnergy()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.Storage.AddResource(new GameResources(EResource.Energy, 5000));
            }
        }

        /// <summary>
        /// Adds 5000 food to the vault
        /// </summary>
        public static void InfiniteFood()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.Storage.AddResource(new GameResources(EResource.Food, 5000));
            }
        }

        /// <summary>
        /// Adds 5000 water to the vault
        /// </summary>
        public static void InfiniteWater()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.Storage.AddResource(new GameResources(EResource.Water, 5000));

            }
        }

        /// <summary>
        /// Adds 5000 Nuka Cola
        /// </summary>
        public static void AddNukaCola()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.Storage.AddResource(new GameResources(EResource.Nuka, 5000));
            }
        }

        /// <summary>
        /// Adds 100 Nuka Cola Quantum
        /// </summary>
        public static void AddNukaColaQuantum()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.Storage.AddResource(new GameResources(EResource.NukaColaQuantum, 100));
            }
        }

        /// <summary>
        /// Adds 50 RedAway 
        /// </summary>
        public static void AddRedAway()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.Storage.AddResource(new GameResources(EResource.RadAway, 50));
            }
        }

        /// <summary>
        /// Adds 50 Stimpacks 
        /// </summary>
        public static void AddStimPack()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.Storage.AddResource(new GameResources(EResource.StimPack, 50));
            }
        }

        /// <summary>
        /// Unlock every room
        /// </summary>
        public static void UnlockRooms()
        {
            if (MonoSingleton<VaultGUIManager>.IsInstanceValid)
            {
                foreach (ERoomType rooms in Enum.GetValues(typeof(ERoomType)))
                {
                    MonoSingleton<VaultGUIManager>.Instance.m_RoomsBuildWindow.Cheat_UnlockRoom(rooms);
                }
            }
        }

        /// <summary>
        /// Unlock every themes for the vault
        /// </summary>
        public static void UnlockThemes()
        {
            if (MonoSingleton<VaultGUIManager>.IsInstanceValid)
            {
                foreach (ESpecialTheme themes in Enum.GetValues(typeof(ESpecialTheme)))
                {
                    foreach (ERoomType rooms in Enum.GetValues(typeof(ERoomType)))
                    {
                        MonoSingleton<VaultGUIManager>.Instance.m_survivalWindow.CollectedThemes.CraftTheme(rooms, themes);
                    }
                    MonoSingleton<GameParameters>.Instance.Items.CraftParameters.ReInitializeCachedRecipesOnce();
                }
            }
        }

        /// <summary>
        /// Set the max Dwellers to 9000
        /// </summary>
        public static void SetDwellersToThousand()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.MaxDwellers = 9000;
            }
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        ///
        /*
        private void Update()
        {
            Validator.Validator.IsInVault();

            if (Options.AdjustDwellers)
            {
                baseMaxDwellers = MonoSingleton<Vault>.Instance.MaxDwellers = baseMaxDwellers * Options.MaxDwellersMultiplier;
            }
            else
            {
                GameStandardValues();
            }
        }
        */
    }
}
