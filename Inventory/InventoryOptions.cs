using System;
using System.Collections.Generic;
using UnityEngine;

namespace Shelter.InventoryOpt
{
    public class InventoryOptions : MonoBehaviour
    {

        /// <summary>
        /// Sets the vault max storage to 9000.
        /// </summary>
        public static void SetVaultStorage(int amount)
        {
            if (MonoSingleton<Vault>.IsInstanceValid && Options.SetVaultMaxStorage)
            {
                MonoSingleton<Vault>.Instance.Inventory.SetMaxItems(amount);
            }
        }

        /// <summary>
        /// Adds every item to the vault storage
        /// </summary>
        public static void AddEveryItem()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                foreach (DwellerWeaponItem weapon in MonoSingleton<GameParameters>.Instance.Items.WeaponsList)
                {
                    DwellerItem item = new DwellerItem(EItemType.Weapon, weapon.GetAsDwellerItem().Id);
                    MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                }

                foreach (DwellerOutfitItem outfit in MonoSingleton<GameParameters>.Instance.Items.OutfitList)
                {
                    DwellerItem item = new DwellerItem(EItemType.Outfit, outfit.GetAsDwellerItem().Id);
                    MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                }

                foreach (DwellerJunkItem junk in MonoSingleton<GameParameters>.Instance.Items.JunksList)
                {
                    DwellerItem item = new DwellerItem(EItemType.Junk, junk.GetAsDwellerItem().Id);
                    MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                }
            }
        }

        /// <summary>
        /// Adds every weapon to the vault storage
        /// </summary>
        public static void AddEveryWeapon()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                foreach (DwellerWeaponItem weapon in MonoSingleton<GameParameters>.Instance.Items.WeaponsList)
                {
                    DwellerItem item = new DwellerItem(EItemType.Weapon, weapon.GetAsDwellerItem().Id);
                    MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                }
            }
        }

        /// <summary>
        /// Adds every outfit to the vault storage
        /// </summary>
        public static void AddEveryOutfit()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                foreach (DwellerOutfitItem outfit in MonoSingleton<GameParameters>.Instance.Items.OutfitList)
                {
                    DwellerItem item = new DwellerItem(EItemType.Outfit, outfit.GetAsDwellerItem().Id);
                    MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                }
            }
        }

        /// <summary>
        /// Adds every junk item to the vault storage
        /// </summary>
        public static void AddEveryJunkItem()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                foreach (DwellerJunkItem junk in MonoSingleton<GameParameters>.Instance.Items.JunksList)
                {
                    DwellerItem item = new DwellerItem(EItemType.Junk, junk.GetAsDwellerItem().Id);
                    MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                }
            }
        }

        /// <summary>
        /// Adds the best weapons to the vault storage
        /// </summary>
        public static void AddTheBestWeapons()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                float bestDamage = 20;
                foreach (DwellerWeaponItem weapon in MonoSingleton<GameParameters>.Instance.Items.WeaponsList)
                {
                    if (bestDamage < weapon.AverageDamage)
                    {
                        DwellerItem item = new DwellerItem(EItemType.Weapon, weapon.GetAsDwellerItem().Id);
                        MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                    }
                }
            }
        }

        /// <summary>
        /// Adds the best outfits to the vault storage
        /// </summary>
        public static void AddTheBestOutfits()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                float bestPrice = 100;
                foreach (DwellerOutfitItem outfit in MonoSingleton<GameParameters>.Instance.Items.OutfitList)
                {
                    if (bestPrice < outfit.SellPrice)
                    {
                        DwellerItem item = new DwellerItem(EItemType.Outfit, outfit.GetAsDwellerItem().Id);
                        MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                    }
                }
            }
        }

        /// <summary>
        /// Adds every legendary weapon to the vault storage
        /// </summary>
        public static void AddLegendaryWeapons()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                foreach (DwellerWeaponItem weapon in MonoSingleton<GameParameters>.Instance.Items.WeaponsList)
                {
                    if (weapon.ItemRarity == EItemRarity.Legendary)
                    {
                        DwellerItem item = new DwellerItem(EItemType.Weapon, weapon.GetAsDwellerItem().Id);
                        MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                    }
                }
            }
        }

        /// <summary>
        /// Adds every legendary outfit to the vault storage
        /// </summary>
        public static void AddLegendaryOutfits()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                foreach (DwellerOutfitItem outfit in MonoSingleton<GameParameters>.Instance.Items.OutfitList)
                {
                    if (outfit.ItemRarity == EItemRarity.Legendary)
                    {
                        DwellerItem item = new DwellerItem(EItemType.Outfit, outfit.GetAsDwellerItem().Id);
                        MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                    }
                }
            }
        }

        /// <summary>
        /// Remove everything from the vault storage
        /// </summary>
        public static void RemoveEveryItemInStorage()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.Inventory.Clear();
            }
        }
    }
}
