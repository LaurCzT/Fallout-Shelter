namespace Shelter
{
    public class Inventory
    {

        /// <summary>
        /// Sets the vault max storage to 9000.
        /// </summary>
        public static void SetVaultStorage(int amount)
        {
            if (MonoSingleton<Vault>.IsInstanceValid && Setting.SetVaultMaxStorage)
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
                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.WeaponsList.Length; i++)
                {
                    DwellerWeaponItem weapon = MonoSingleton<GameParameters>.Instance.Items.WeaponsList[i];
                    DwellerItem item = new DwellerItem(EItemType.Weapon, weapon.GetAsDwellerItem().Id);

                    MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                }

                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.OutfitList.Length; i++)
                {
                    DwellerOutfitItem outfit = MonoSingleton<GameParameters>.Instance.Items.OutfitList[i];
                    DwellerItem item = new DwellerItem(EItemType.Outfit, outfit.GetAsDwellerItem().Id);

                    MonoSingleton<Vault>.Instance.Inventory.AddItem(item);
                }

                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.JunksList.Length; i++)
                {
                    DwellerJunkItem junk = MonoSingleton<GameParameters>.Instance.Items.JunksList[i];
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
                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.WeaponsList.Length; i++)
                {
                    DwellerWeaponItem weapon = MonoSingleton<GameParameters>.Instance.Items.WeaponsList[i];
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
                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.OutfitList.Length; i++)
                {
                    DwellerOutfitItem outfit = MonoSingleton<GameParameters>.Instance.Items.OutfitList[i];
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
                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.JunksList.Length; i++)
                {
                    DwellerJunkItem junk = MonoSingleton<GameParameters>.Instance.Items.JunksList[i];
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
                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.WeaponsList.Length; i++)
                {
                    DwellerWeaponItem weapon = MonoSingleton<GameParameters>.Instance.Items.WeaponsList[i];
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
                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.OutfitList.Length; i++)
                {
                    DwellerOutfitItem outfit = MonoSingleton<GameParameters>.Instance.Items.OutfitList[i];
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
                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.WeaponsList.Length; i++)
                {
                    DwellerWeaponItem weapon = MonoSingleton<GameParameters>.Instance.Items.WeaponsList[i];
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
                for (int i = 0; i < MonoSingleton<GameParameters>.Instance.Items.OutfitList.Length; i++)
                {
                    DwellerOutfitItem outfit = MonoSingleton<GameParameters>.Instance.Items.OutfitList[i];
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
