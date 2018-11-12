using UnityEngine;

namespace Shelter.VisualOpt {

    public class VisualOptions : MonoBehaviour
    {
        static Camera cam;

        private void Start()
        {
            cam = Camera.main;
        }

        private void OnGUI()
        {
            DrawDwellers();
        }

        public static void DrawDwellers()
        {
            if (Options.DwellerESP)
            {
                if (MonoSingleton<DwellerManager>.IsInstanceValid)
                {
                    foreach (Dweller person in MonoSingleton<DwellerManager>.Instance.Dwellers)
                    {
                        if (person == null)
                            return;

                        GUI.color = Color.white;

                        Vector3 pos = person.transform.position;
                        Vector3 posScreen = cam.WorldToScreenPoint(pos);

                        if (posScreen.z > 0 & posScreen.y < Screen.width - 2)
                        {
                            posScreen.y = Screen.height - (posScreen.y + 2f);
                            Render.DrawString(new Vector2(posScreen.x, posScreen.y), (person.Name + " " + person.LastName));

                        }
                    }
                }
            }
        }
    }
}
