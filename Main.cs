using UnityEngine;

namespace Shelter
{
    public class Main  : MonoBehaviour
    {
        private void OnGUI()
        {
            if(Options.Watermark)
            {
                GUI.Label(new Rect(20, 20, 200, 60), "UnKnoWnCheaTs.me | Shv00");
            }
        }

        private void Update()
        {
            if(Input.GetKey(KeyCode.Delete))
            {
                Loader.Unload();
            }
        }
    }
}
