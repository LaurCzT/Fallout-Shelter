using UnityEngine;
using Shelter.DwellerOpt;
using Shelter.VaultOpt;

namespace Shelter.CheatOpt
{
    public class CheatOptions : MonoBehaviour
    {
        private void OnGUI()
        {
            if (Options.Watermark)
            {
                GUI.Label(new Rect(20, 20, 200, 60), "UnKnoWnCheaTs.me | Shv00");
            }
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Delete))
            {
                Loader.Unload();
            }

            if(Input.GetKey(KeyCode.F1))
            {
                VaultOptions.InfiniteEnergy(5000);
            }

            if (Input.GetKey(KeyCode.F2))
            {
                VaultOptions.InfiniteFood(5000);
            }

            if (Input.GetKey(KeyCode.F3))
            {
                VaultOptions.InfiniteWater(5000);
            }
        }
    }
}
