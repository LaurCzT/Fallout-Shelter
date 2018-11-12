using UnityEngine;
using System.Collections;
using Shelter.DwellerOpt;
using Shelter.EventOpt;
using Shelter.InventoryOpt;
using Shelter.VaultOpt;
using Shelter.LunchBoxOpt;
using Shelter.VisualOpt;

namespace Shelter
{
    public class Menu : MonoBehaviour
    {

        private Rect MainWindow;
        private Rect DwellerWindow;
        private Rect EventWindow;
        private Rect InventoryWindow;
        private Rect VaultWindow;
        private Rect LunchboxWindow;
        private Rect VisualWindow;

        public bool Visible = true;
        public bool DwellerVisible = false;
        public bool EventVisible = false;
        public bool InventoryVisble = false;
        public bool VaultVisible = false;
        public bool LunchBoxVisible = false;
        public bool VisualVisible = false;

        public void Start()
        {
            MainWindow = new Rect(10f, 10f, 250f, 150f);
            DwellerWindow = new Rect(10f, 10f, 250f, 150f);
            EventWindow = new Rect(10f, 10f, 250f, 150f);
            InventoryWindow = new Rect(10f, 10f, 250f, 150f);
            VaultWindow = new Rect(10f, 10f, 250f, 150f);
            LunchboxWindow = new Rect(10f, 10f, 250f, 150f);
            VisualWindow = new Rect(10f, 10f, 50f, 50f);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
                Visible = !Visible;

            if (Input.GetKeyDown(KeyCode.Delete))
                Loader.Unload();
        }


        private void OnGUI()
        {
            if (!Visible)
            {
                return;
            }

            MainWindow = GUILayout.Window(0, MainWindow, new GUI.WindowFunction(Draw), "Fallout Shelter", new GUILayoutOption[0]);

            if (DwellerVisible)
            {
                DwellerWindow = GUILayout.Window(1, DwellerWindow, new GUI.WindowFunction(DrawDwellerOptions), "Dweller Options", new GUILayoutOption[0]);
            }

            if (EventVisible)
            {
                EventWindow = GUILayout.Window(2, EventWindow, new GUI.WindowFunction(DrawEventOptions), "Event Options", new GUILayoutOption[0]);
            }

            if (InventoryVisble)
            {
                InventoryWindow = GUILayout.Window(3, InventoryWindow, new GUI.WindowFunction(DrawInventoryOptions), "Inventory Options", new GUILayoutOption[0]);
            }

            if (VaultVisible)
            {
                VaultWindow = GUILayout.Window(4, VaultWindow, new GUI.WindowFunction(DrawVaultOptions), "Vault Options", new GUILayoutOption[0]);
            }

            if (LunchBoxVisible)
            {
                LunchboxWindow = GUILayout.Window(5, LunchboxWindow, new GUI.WindowFunction(DrawLunchBoxOptions), "LunchBox Options", new GUILayoutOption[0]);
            }

            if (VisualVisible)
            {
                VisualWindow = GUILayout.Window(6, VisualWindow, new GUI.WindowFunction(DrawVisualOptions), "Visual Options", new GUILayoutOption[0]);
            }
        }

        /// <summary>
        /// Our Main menu, first thing you will see when you start the cheat.
        /// </summary>
        /// <param name="id"></param>
        private void Draw(int id)
        {
            Options.Watermark = GUILayout.Toggle(Options.Watermark, "Watermark", new GUILayoutOption[0]);

            GUILayout.Label("Insert for Menu", new GUILayoutOption[0]);
            GUILayout.Label("Delete to unload the cheat", new GUILayoutOption[0]);

            GUILayout.Space(+10f);

            if (GUILayout.Button("Dweller Options", new GUILayoutOption[0]))
            {
                DwellerWindow.x = MainWindow.width + 20f;
                DwellerVisible = !DwellerVisible;
            }

            if (GUILayout.Button("Event Options", new GUILayoutOption[0]))
            {
                EventWindow.x = MainWindow.width + 290f;
                EventVisible = !EventVisible;
            }

            if (GUILayout.Button("Inventory Options", new GUILayoutOption[0]))
            {
                InventoryWindow.x = MainWindow.width + 290f;
                InventoryWindow.y = EventWindow.width - 75f;
                InventoryVisble = !InventoryVisble;
            }

            if (GUILayout.Button("Vault Options", new GUILayoutOption[0]))
            {
                VaultWindow.x = InventoryWindow.width + 580f;
                VaultVisible = !VaultVisible;
            }

            if (GUILayout.Button("Lunchbox Options", new GUILayoutOption[0]))
            {
                LunchboxWindow.y = MainWindow.width + 80f;
                LunchBoxVisible = !LunchBoxVisible;
            }

            if (GUILayout.Button("Visual Options", new GUILayoutOption[0]))
            {
                VisualWindow.x = VaultWindow.width + 580f;
                VisualWindow.y = VaultWindow.width + 80f;
                VisualVisible = !VisualVisible;
            }

            GUILayout.Space(20f);

            if (GUILayout.Button("Unload", new GUILayoutOption[0]))
            {
                Loader.Unload();
            }

            GUI.DragWindow();
        }

        /// <summary>
        /// The second menu, for all the dwellers in the vault
        /// </summary>
        /// <param name="id"></param>
        private void DrawDwellerOptions(int id)
        {
            if (Options.AlwaysHappy)
            {
                DwellerOptions.AlwaysHappy();
            }
            Options.AlwaysHappy = GUILayout.Toggle(Options.AlwaysHappy, "Always Happy", new GUILayoutOption[0]);

            if(Options.SetDwellerMaxHealth)
            {
                DwellerOptions.DwellersMaxHealth();
            }
            Options.SetDwellerMaxHealth = GUILayout.Toggle(Options.SetDwellerMaxHealth, "Set Dwellers Health to max", new GUILayoutOption[0]);

            if (Options.SetBiggerCriticalHitMeter)
            {
                DwellerOptions.BiggerCriticalHitMeter();
            }
            Options.SetBiggerCriticalHitMeter = GUILayout.Toggle(Options.SetBiggerCriticalHitMeter, "Set Larger Critical Hit Meter", new GUILayoutOption[0]);

            if (Options.SetHigherCriticalHit)
            {
                DwellerOptions.HigherCriticalHit();
            }
            Options.SetHigherCriticalHit = GUILayout.Toggle(Options.SetHigherCriticalHit, "Set Critical Hit to 5000", new GUILayoutOption[0]);

            GUILayout.Space(+10f);

            if (GUILayout.Button("Level Up all Dwellers", new GUILayoutOption[0]) )
            {
                DwellerOptions.LevelUpAllDwellers();
            }

            if (GUILayout.Button("Every Dweller (S.P.E.C.I.A.L)", new GUILayoutOption[0]))
            {
                DwellerOptions.EveryDwellerIsSpecial();
            }

            if (GUILayout.Button("Every Woman Is Pregnant", new GUILayoutOption[0]))
            {
                DwellerOptions.EveryWomanIsPregnant();
            }

            if (GUILayout.Button("Every Woman Is Not Pregnant", new GUILayoutOption[0]))
            {
                DwellerOptions.EveryWomanIsNotPregnant();
            }

            if (GUILayout.Button("Spawn Common Dweller", new GUILayoutOption[0]))
            {
                DwellerOptions.SpawnCommonDweller();
            }

            if (GUILayout.Button("Spawn Normal Dweller", new GUILayoutOption[0]))
            {
                DwellerOptions.SpawnNormalDweller();
            }

            if (GUILayout.Button("Spawn Rare Dweller", new GUILayoutOption[0]))
            {
                DwellerOptions.SpawnRareDweller();
            }

            if (GUILayout.Button("Spawn Legendary Dweller", new GUILayoutOption[0]))
            {
                DwellerOptions.SpawnLegendaryDweller();
            }

            GUILayout.Space(+15f);

            GUILayout.Label("Experiential (Reset your game to fix it)", new GUILayoutOption[0]);

            Options.EnableSpeedDwellers = GUILayout.Toggle(Options.EnableSpeedDwellers, "Enable Speedhack for Dwellers", new GUILayoutOption[0]);

            GUILayout.Space(+5f);

            GUILayout.Label(string.Format("Running Speed {0}", Options.RunningSpeedMultiplier), new GUILayoutOption[0]);
            Options.RunningSpeedMultiplier = Mathf.Round(GUILayout.HorizontalSlider(Options.RunningSpeedMultiplier, 1f, 50f, new GUILayoutOption[0]) * 50f) / 50f;

            GUILayout.Space(+5f);

            GUILayout.Label(string.Format("Walking Speed {0}", Options.WalkingSpeedMultiplier), new GUILayoutOption[0]);
            Options.WalkingSpeedMultiplier = Mathf.Round(GUILayout.HorizontalSlider(Options.WalkingSpeedMultiplier, 1f, 50f, new GUILayoutOption[0]) * 50f) / 50f;

            GUI.DragWindow();
        }

        /// <summary>
        /// The Third menu, for all the Events in the vault
        /// </summary>
        /// <param name="id"></param>
        private void DrawEventOptions(int id)
        {
            if(Options.NoRandomEvent)
            {
                EventOptions.NoRandomEvents();
            }
            Options.NoRandomEvent = GUILayout.Toggle(Options.NoRandomEvent, "No random event", new GUILayoutOption[0]);

            if (GUILayout.Button("Start Raider Attack", new GUILayoutOption[0]))
            {
                EventOptions.StartRaiderAttack();
            }

            if (GUILayout.Button("Start Ghoul Attack", new GUILayoutOption[0]))
            {
                EventOptions.StartGhoulAttack();
            }

            if (GUILayout.Button("Start Deathclaw Attack", new GUILayoutOption[0]))
            {
                EventOptions.StartDeathClawAttack();
            }
            GUI.DragWindow();
        }

        /// <summary>
        /// The Fourth menu, for the storage in the vault
        /// </summary>
        /// <param name="id"></param>
        private void DrawInventoryOptions(int id)
        {
            if(Options.SetVaultMaxStorage)
            {
                InventoryOptions.SetVaultStorage(9000);
            }
            Options.SetVaultMaxStorage = GUILayout.Toggle(Options.SetVaultMaxStorage, "Set storage max 9000", new GUILayoutOption[0]);

            if (GUILayout.Button("Add Every Item", new GUILayoutOption[0]))
            {
                InventoryOptions.AddEveryItem();
            }

            if (GUILayout.Button("Add Every Weapon", new GUILayoutOption[0]))
            {
                InventoryOptions.AddEveryWeapon();
            }

            if (GUILayout.Button("Add Every Outfit", new GUILayoutOption[0]))
            {
                InventoryOptions.AddEveryWeapon();
            }

            if (GUILayout.Button("Add Every Junk Item", new GUILayoutOption[0]))
            {
                InventoryOptions.AddEveryJunkItem();
            }

            if (GUILayout.Button("Add The Best Weapons", new GUILayoutOption[0]))
            {
                InventoryOptions.AddTheBestWeapons();
            }

            if (GUILayout.Button("Add The Best Outfits", new GUILayoutOption[0]))
            {
                InventoryOptions.AddTheBestOutfits();
            }

            if (GUILayout.Button("Add Legendary Weapon", new GUILayoutOption[0]))
            {
                InventoryOptions.AddLegendaryWeapons();
            }

            if (GUILayout.Button("Add Legendary Outfits", new GUILayoutOption[0]))
            {
                InventoryOptions.AddLegendaryOutfits();
            }

            if (GUILayout.Button("Remove Everything", new GUILayoutOption[0]))
            {
                InventoryOptions.RemoveEveryItemInStorage();
            }

            GUI.DragWindow();
        }

        /// <summary>
        /// The fith menu, for all the vault options
        /// </summary>
        /// <param name="id"></param>
        private void DrawVaultOptions(int id)
        {
            if (GUILayout.Button("Set Energy to 5000", new GUILayoutOption[0]))
            {
                VaultOptions.InfiniteEnergy(5000);
            }

            if (GUILayout.Button("Set Food to 5000", new GUILayoutOption[0]))
            {
                VaultOptions.InfiniteFood(5000);
            }

            if (GUILayout.Button("Set Water to 5000", new GUILayoutOption[0]))
            {
                VaultOptions.InfiniteWater(5000);
            }

            if (GUILayout.Button("Add 5000 Nuka Cola", new GUILayoutOption[0]))
            {
                VaultOptions.AddNukaCola(5000);
            }

            if (GUILayout.Button("Add 100 Nuka Cola Quantum", new GUILayoutOption[0]))
            {
                VaultOptions.AddNukaColaQuantum(100);
            }

            if (GUILayout.Button("Add 50 RedAway", new GUILayoutOption[0]))
            {
                VaultOptions.AddRedAway(50);
            }

            if (GUILayout.Button("Add 50 Stimpack", new GUILayoutOption[0]))
            {
                VaultOptions.AddStimPack(50);
            }

            if (GUILayout.Button("Unlock Every Room", new GUILayoutOption[0]))
            {
                VaultOptions.UnlockRooms();
            }

            if (GUILayout.Button("Unlock Every Theme", new GUILayoutOption[0]))
            {
                VaultOptions.UnlockThemes();
            }

            if (GUILayout.Button("Set Max Dwellers to 9000", new GUILayoutOption[0]))
            {
                VaultOptions.SetDwellersToThousand(9000);
            }

            GUI.DragWindow();
        }

        private void DrawLunchBoxOptions(int id)
        {
            if (GUILayout.Button("Add 1 Regular Luncbox", new GUILayoutOption[0]))
            {
                LunchboxOptions.AddLunchBox(1);
            }

            if (GUILayout.Button("Add 1 LunchBox Mr.Handy", new GUILayoutOption[0]))
            {
                LunchboxOptions.AddLunchBoxMrHandy(1);
            }

            if (GUILayout.Button("Add 1 Pet Carrier LunchBox", new GUILayoutOption[0]))
            {
                LunchboxOptions.AddLunchBoxPet(1);
            }

            if (GUILayout.Button("Add 1 Starter Lunchbox", new GUILayoutOption[0]))
            {
                LunchboxOptions.AddLunchBoxStarter(1);
            }

            GUI.DragWindow();
        }

        private void DrawVisualOptions(int id)
        {
            if (Options.DwellerESP)
            {
                VisualOptions.DrawDwellers();
            }
            Options.DwellerESP = GUILayout.Toggle(Options.DwellerESP, "Dweller ESP", new GUILayoutOption[0]);

            GUI.DragWindow();
        }
    }
}
