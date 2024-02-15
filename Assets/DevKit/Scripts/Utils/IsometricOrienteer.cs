using DevKit.Debugging;
using NaughtyAttributes;
using UnityEngine;

namespace DevKit.Utils
{
    public class IsometricOrienteer : MonoBehaviour
    {
        private readonly Vector3 isometricVector = new(30f, 40f, 0f);

        [Button]
        public void Orient()
        {
            transform.rotation = Quaternion.Euler(isometricVector);

            ConsoleLogger.Log($"{nameof(IsometricOrienteer)}: game object \"{name}\" has been oriented to isometric view.");
        }
    }
}
