using UnityEngine;

namespace Shelter
{
    public class Loader
    {
        // Declare our gameobject
        public static GameObject gameObject;

        // Our loader method
        public static void Load()
        {
            // Create an instance of the GameObject
            gameObject = new GameObject();

            // Adding the monobehaviours components to our GameObject
            gameObject.AddComponent<UI.Menu>();

            // Telling unity not to destroy our GameObject on level change
            Object.DontDestroyOnLoad(gameObject);
        }

        public static void UnloadGameObject()
        {
            // Destroy our GameObject
            Object.Destroy(gameObject);
        }
    }
}
