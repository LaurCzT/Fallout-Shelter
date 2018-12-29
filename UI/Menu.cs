using UnityEngine;

namespace Shelter.UI
{
    public class Menu : MonoBehaviour
    {
        // Delcare our Rect Windows
        private Rect MainWindow;
        private Rect DwellerWindow;
        private Rect EventWindow;
        private Rect InventoryWindow;
        private Rect VaultWindow;
        private Rect LunchboxWindow;

        public bool Visible = true;
        public bool DwellerVisible = false;
        public bool EventVisible = false;
        public bool InventoryVisble = false;
        public bool VaultVisible = false;
        public bool LunchBoxVisible = false;
        public bool VisualVisible = false;

        /// <summary>
        /// Our start function that will be called once in the lifecycle. When the game starts
        /// </summary>
        public void Start()
        {
            MainWindow = new Rect(10f, 10f, 250f, 150f);
            DwellerWindow = new Rect(30f, 10f, 250f, 150f);
            EventWindow = new Rect(300f, 10f, 250f, 150f);
            InventoryWindow = new Rect(300f, -70f, 250f, 150f);
            VaultWindow = new Rect(600f, 10f, 250f, 150f);
            LunchboxWindow = new Rect(10f, 80f, 250f, 150f);
        }

        /// <summary>
        /// The updagte function will update on every frame change
        /// </summary>
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
                Visible = !Visible;

            if (Input.GetKeyDown(KeyCode.Delete))
                Loader.UnloadGameObject();

            if (Input.GetKey(KeyCode.F7))
                CVault.InfiniteEnergy(5000);

            if (Input.GetKey(KeyCode.F8))
                CVault.InfiniteFood(5000);

            if (Input.GetKey(KeyCode.F9))
                CVault.InfiniteWater(5000);
        }

        /// <summary>
        /// OnGUI is being redrawn on every frame update
        /// </summary>
        private void OnGUI()
        {
            GUI.Label(new Rect(20, 20, 200, 60), "UnKnoWnCheaTs.me | B74k");

            if (!Visible)
                return;

            MainWindow = GUILayout.Window(0, MainWindow, new GUI.WindowFunction(RenderUI), "Fallout Shelter", new GUILayoutOption[0]);

            if (DwellerVisible)
                DwellerWindow = GUILayout.Window(1, DwellerWindow, new GUI.WindowFunction(RenderUI), "Dweller Options", new GUILayoutOption[0]);
                
            if (EventVisible)
                EventWindow = GUILayout.Window(2, EventWindow, new GUI.WindowFunction(RenderUI), "Event Options", new GUILayoutOption[0]);

            if (InventoryVisble)
                InventoryWindow = GUILayout.Window(3, InventoryWindow, new GUI.WindowFunction(RenderUI), "Inventory Options", new GUILayoutOption[0]);

            if (VaultVisible)
                VaultWindow = GUILayout.Window(4, VaultWindow, new GUI.WindowFunction(RenderUI), "Vault Options", new GUILayoutOption[0]);

            if (LunchBoxVisible)
                LunchboxWindow = GUILayout.Window(5, LunchboxWindow, new GUI.WindowFunction(RenderUI), "LunchBox Options", new GUILayoutOption[0]);
        }

        private void RenderUI(int id)
        {
            switch (id)
            {
                case 0:
                    GUILayout.Label("Insert for Menu", new GUILayoutOption[0]);
                    GUILayout.Label("Delete to unload the cheat", new GUILayoutOption[0]);

                    GUILayout.Space(10);

                    if (GUILayout.Button("Dweller Options", new GUILayoutOption[0]))
                        DwellerVisible = !DwellerVisible;

                    if (GUILayout.Button("Event Options", new GUILayoutOption[0]))
                        EventVisible = !EventVisible;

                    if (GUILayout.Button("Inventory Options", new GUILayoutOption[0]))
                        InventoryVisble = !InventoryVisble;

                    if (GUILayout.Button("Vault Options", new GUILayoutOption[0]))
                        VaultVisible = !VaultVisible;

                    if (GUILayout.Button("Lunchbox Options", new GUILayoutOption[0]))
                        LunchBoxVisible = !LunchBoxVisible;

                    GUILayout.Space(10f);

                    if (GUILayout.Button("Unload", new GUILayoutOption[0]))
                        Loader.UnloadGameObject();

                    break;
                case 1:

                    Setting.AlwaysHappy = GUILayout.Toggle(Setting.AlwaysHappy, "Always Happy", new GUILayoutOption[0]);
                    Setting.SetDwellerMaxHealth = GUILayout.Toggle(Setting.SetDwellerMaxHealth, "Set Dwellers Health to max", new GUILayoutOption[0]);
                    Setting.SetBiggerCriticalHitMeter = GUILayout.Toggle(Setting.SetBiggerCriticalHitMeter, "Set Larger Critical Hit Meter", new GUILayoutOption[0]);
                    Setting.SetHigherCriticalHit = GUILayout.Toggle(Setting.SetHigherCriticalHit, "Set Critical Hit to 5000", new GUILayoutOption[0]);

                    if (Setting.AlwaysHappy)
                        CDweller.AlwaysHappy();

                    if (Setting.SetDwellerMaxHealth)
                        CDweller.DwellersMaxHealth();

                    if (Setting.SetBiggerCriticalHitMeter)
                        CDweller.BiggerCriticalHitMeter();

                    if (Setting.SetHigherCriticalHit)
                        CDweller.HigherCriticalHit();

                    GUILayout.Space(+10f);

                    if (GUILayout.Button("Level Up all Dwellers", new GUILayoutOption[0]))
                        CDweller.LevelUpAllDwellers();

                    if (GUILayout.Button("Every Dweller (S.P.E.C.I.A.L)", new GUILayoutOption[0]))
                        CDweller.EveryDwellerIsSpecial();

                    if (GUILayout.Button("Every Woman Is Pregnant", new GUILayoutOption[0]))
                        CDweller.EveryWomanIsPregnant();

                    if (GUILayout.Button("Every Woman Is Not Pregnant", new GUILayoutOption[0]))
                        CDweller.EveryWomanIsNotPregnant();

                    if (GUILayout.Button("Spawn Common Dweller", new GUILayoutOption[0]))
                        CDweller.SpawnCommonDweller();

                    if (GUILayout.Button("Spawn Normal Dweller", new GUILayoutOption[0]))
                        CDweller.SpawnNormalDweller();

                    if (GUILayout.Button("Spawn Rare Dweller", new GUILayoutOption[0]))
                        CDweller.SpawnRareDweller();

                    if (GUILayout.Button("Spawn Legendary Dweller", new GUILayoutOption[0]))
                        CDweller.SpawnLegendaryDweller();
                    break;
                case 2:
                    Setting.NoRandomEvent = GUILayout.Toggle(Setting.NoRandomEvent, "No random event", new GUILayoutOption[0]);

                    if (Setting.NoRandomEvent)
                        Event.NoRandomEvents();

                    if (GUILayout.Button("Start Raider Attack", new GUILayoutOption[0]))
                        Event.StartRaiderAttack();

                    if (GUILayout.Button("Start Ghoul Attack", new GUILayoutOption[0]))
                        Event.StartGhoulAttack();

                    if (GUILayout.Button("Start Deathclaw Attack", new GUILayoutOption[0]))
                        Event.StartDeathClawAttack();

                    break;
                case 3:
                    Setting.SetVaultMaxStorage = GUILayout.Toggle(Setting.SetVaultMaxStorage, "Set storage max 9000", new GUILayoutOption[0]);

                    if (Setting.SetVaultMaxStorage)
                        Inventory.SetVaultStorage(9000);

                    if (GUILayout.Button("Add Every Item", new GUILayoutOption[0]))
                        Inventory.AddEveryItem();

                    if (GUILayout.Button("Add Every Weapon", new GUILayoutOption[0]))
                        Inventory.AddEveryWeapon();

                    if (GUILayout.Button("Add Every Outfit", new GUILayoutOption[0]))
                        Inventory.AddEveryWeapon();

                    if (GUILayout.Button("Add Every Junk Item", new GUILayoutOption[0]))
                        Inventory.AddEveryJunkItem();

                    if (GUILayout.Button("Add The Best Weapons", new GUILayoutOption[0]))
                        Inventory.AddTheBestWeapons();

                    if (GUILayout.Button("Add The Best Outfits", new GUILayoutOption[0]))
                        Inventory.AddTheBestOutfits();

                    if (GUILayout.Button("Add Legendary Weapon", new GUILayoutOption[0]))
                        Inventory.AddLegendaryWeapons();

                    if (GUILayout.Button("Add Legendary Outfits", new GUILayoutOption[0]))
                        Inventory.AddLegendaryOutfits();

                    if (GUILayout.Button("Remove Everything", new GUILayoutOption[0]))
                        Inventory.RemoveEveryItemInStorage();
                    break;
                case 4:
                    if (GUILayout.Button("Set Energy to 5000", new GUILayoutOption[0]))
                        CVault.InfiniteEnergy(5000);

                    if (GUILayout.Button("Set Food to 5000", new GUILayoutOption[0]))
                        CVault.InfiniteFood(5000);

                    if (GUILayout.Button("Set Water to 5000", new GUILayoutOption[0]))
                        CVault.InfiniteWater(5000);

                    if (GUILayout.Button("Add 5000 Nuka Cola", new GUILayoutOption[0]))
                        CVault.AddNukaCola(5000);

                    if (GUILayout.Button("Add 100 Nuka Cola Quantum", new GUILayoutOption[0]))
                        CVault.AddNukaColaQuantum(100);

                    if (GUILayout.Button("Add 50 RedAway", new GUILayoutOption[0]))
                        CVault.AddRedAway(50);

                    if (GUILayout.Button("Add 50 Stimpack", new GUILayoutOption[0]))
                        CVault.AddStimPack(50);

                    if (GUILayout.Button("Unlock Every Room", new GUILayoutOption[0]))
                        CVault.UnlockRooms();

                    if (GUILayout.Button("Unlock Every Theme", new GUILayoutOption[0]))
                        CVault.UnlockThemes();

                    if (GUILayout.Button("Set Max Dwellers to 9000", new GUILayoutOption[0]))
                        CVault.SetDwellersToThousand(9000);
                    break;
                case 5:
                    if (GUILayout.Button("Add 1 Regular Luncbox", new GUILayoutOption[0]))
                        Lunchbox.AddLunchBox(1);

                    if (GUILayout.Button("Add 1 LunchBox Mr.Handy", new GUILayoutOption[0]))
                        Lunchbox.AddLunchBoxMrHandy(1);

                    if (GUILayout.Button("Add 1 Pet Carrier LunchBox", new GUILayoutOption[0]))
                        Lunchbox.AddLunchBoxPet(1);
                    
                    if (GUILayout.Button("Add 1 Starter Lunchbox", new GUILayoutOption[0]))
                        Lunchbox.AddLunchBoxStarter(1);
                    break;
                default:
                    break;
            }
            GUI.DragWindow();
        }
    }
}
