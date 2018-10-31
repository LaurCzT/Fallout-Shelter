using UnityEngine;
using Shelter.DwellerOpt;
using Shelter.EventOpt;
using Shelter.InventoryOpt;
using Shelter.VaultOpt;
using Shelter.LunchBoxOpt;

namespace Shelter
{
    public class Menu : MonoBehaviour
    {
        private Rect _window;
        private Rect _window2;
        private Rect _window3;
        private Rect _window4;
        private Rect _window5;
        private Rect _window6;

        public bool Visible = true;
        public bool DwellerVisible = false;
        public bool EventVisible = false;
        public bool InventoryVisble = false;
        public bool VaultVisible = false;
        public bool LunchBoxVisible = false;

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {

            // Main Menu
            _window = new Rect(10f, 10f, 250f, 150f);

            // Dweller Options
            _window2 = new Rect(10f, 10f, 250f, 150f);

            // Eevent Options
            _window3 = new Rect(10f, 10f, 250f, 150f);

            // Inventory Options
            _window4 = new Rect(10f, 10f, 250f, 150f);

            // Vault Options
            _window5 = new Rect(10f, 10f, 250f, 150f);

            // Pets Options
            _window6 = new Rect(10f, 10f, 250f, 150f);
        }

        private void ToggleMenu()
        {
            if(Input.GetKeyDown(KeyCode.Insert))
            {
                Visible = !Visible;
            }
        }

        private void Update()
        {

            ToggleMenu();
        }

        /// <summary>
        /// 
        /// </summary>
        private void OnGUI()
        {

            if (!Visible)
            {
                return;
            }

            _window = GUILayout.Window(0, _window, new GUI.WindowFunction(Draw), "Fallout Shelter", new GUILayoutOption[0]);

            if (DwellerVisible)
            {
                _window2 = GUILayout.Window(1, _window2, new GUI.WindowFunction(DrawDwellerOptions), "Dweller Options", new GUILayoutOption[0]);
            }

            if (EventVisible)
            {
                _window3 = GUILayout.Window(2, _window3, new GUI.WindowFunction(DrawEventOptions), "Event Options", new GUILayoutOption[0]);
            }

            if (InventoryVisble)
            {
                _window4 = GUILayout.Window(3, _window4, new GUI.WindowFunction(DrawInventoryOptions), "Inventory Options", new GUILayoutOption[0]);
            }

            if (VaultVisible)
            {
                _window5 = GUILayout.Window(4, _window5, new GUI.WindowFunction(DrawVaultOptions), "Vault Options", new GUILayoutOption[0]);
            }

            if (LunchBoxVisible)
            {
                _window6 = GUILayout.Window(5, _window6, new GUI.WindowFunction(DrawLunchBoxOptions), "Pet Options", new GUILayoutOption[0]);
            }

        }

        /// <summary>
        /// Our Main menu, first thing you will see when you start the cheat.
        /// </summary>
        /// <param name="id"></param>
        private void Draw(int id)
        {
            Options.Watermark = GUILayout.Toggle(Options.Watermark, "Watermark", new GUILayoutOption[0]);

            GUILayout.Space(+10f);

            if (GUILayout.Button("Dweller Options", new GUILayoutOption[0]))
            {
                _window2.x = _window.width + 20f;
                DwellerVisible = !DwellerVisible;
            }

            if (GUILayout.Button("Event Options", new GUILayoutOption[0]))
            {
                _window3.x = _window.width + 40f;
                EventVisible = !EventVisible;
            }

            if (GUILayout.Button("Inventory Options", new GUILayoutOption[0]))
            {
                _window4.x = _window3.width + 80f;
                InventoryVisble = !InventoryVisble;
            }

            if (GUILayout.Button("Vault Options", new GUILayoutOption[0]))
            {
                _window5.x = _window4.width + 20f;
                _window5.y = _window4.width + 40f;
                VaultVisible = !VaultVisible;
            }

            if (GUILayout.Button("Lunchbox Options", new GUILayoutOption[0]))
            {
                _window5.x = _window4.width + 80f;
                _window5.y = _window4.width + 40f;
                LunchBoxVisible = !LunchBoxVisible;
            }

            GUILayout.Space(5f);

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

            GUILayout.Space(+10f);

            if (GUILayout.Button("Level Up all Dwellers", new GUILayoutOption[0]))
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

            GUI.DragWindow();
        }

        /// <summary>
        /// The Third menu, for all the Events in the vault
        /// </summary>
        /// <param name="id"></param>
        private void DrawEventOptions(int id)
        {
            if (Options.NoRandomEvent)
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
            if (Options.SetVaultMaxStorage)
            {
                InventoryOptions.SetVaultStorage();
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
                VaultOptions.InfiniteEnergy();
            }

            if (GUILayout.Button("Set Food to 5000", new GUILayoutOption[0]))
            {
                VaultOptions.InfiniteFood();
            }

            if (GUILayout.Button("Set Water to 5000", new GUILayoutOption[0]))
            {
                VaultOptions.InfiniteWater();
            }

            if (GUILayout.Button("Add 5000 Nuka Cola", new GUILayoutOption[0]))
            {
                VaultOptions.AddNukaCola();
            }

            if (GUILayout.Button("Add 100 Nuka Cola Quantum", new GUILayoutOption[0]))
            {
                VaultOptions.AddNukaColaQuantum();
            }

            if (GUILayout.Button("Add 50 RedAway", new GUILayoutOption[0]))
            {
                VaultOptions.AddRedAway();
            }

            if (GUILayout.Button("Add 50 Stimpack", new GUILayoutOption[0]))
            {
                VaultOptions.AddStimPack();
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
                VaultOptions.SetDwellersToThousand();
            }

            GUI.DragWindow();
        }

        private void DrawLunchBoxOptions(int id)
        {
            if (GUILayout.Button("Add 1 Regular Luncbox", new GUILayoutOption[0]))
            {
                LunchboxOptions.AddLunchBox();
            }

            if (GUILayout.Button("Add 1 LunchBox Mr.Handy", new GUILayoutOption[0]))
            {
                LunchboxOptions.AddLunchBoxMrHandy();
            }

            if (GUILayout.Button("Add 1 Pet Carrier LunchBox", new GUILayoutOption[0]))
            {
                LunchboxOptions.AddLunchBoxPet();
            }

            if (GUILayout.Button("Add 1 Starter Lunchbox", new GUILayoutOption[0]))
            {
                LunchboxOptions.AddLunchBoxStarter();
            }

            GUI.DragWindow();
        }
    }
}
