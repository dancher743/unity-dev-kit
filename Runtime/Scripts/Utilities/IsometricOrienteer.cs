using DevKit.Debugging;
using NaughtyAttributes;
using UnityEngine;

namespace DevKit.Utilities
{
    public class IsometricOrienteer : MonoBehaviour
    {
        [Button]
        public void Orient()
        {
            var isometricVector = new Vector3(30f, 40f, 0f);

            transform.rotation = Quaternion.Euler(isometricVector);

            ConsoleLogger.Log($"{nameof(IsometricOrienteer)}: game object \"{name}\" has been oriented to isometric view.");
        }
    }
}
