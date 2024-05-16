using DevKit.Debugging;
using UnityEngine;

namespace DevKit.Utilities
{
    public class TargetFollower : MonoBehaviour
    {
        [SerializeField]
        private Transform target;

        [SerializeField]
        private float smoothTime;

        public void LateUpdate()
        {
            if (target == null)
            {
                ConsoleLogger.Log($"Couldn't follow the {nameof(target)} of {nameof(TargetFollower)} on {gameObject.name} game object because it's null.");
                return;
            }

            if (smoothTime == 0f)
            {
                transform.position = target.position;
            }
            else
            {
                var currentVelocity = Vector3.zero;
                transform.position = Vector3.SmoothDamp(transform.position, target.position, ref currentVelocity, smoothTime);
            }
        }
    }
}
