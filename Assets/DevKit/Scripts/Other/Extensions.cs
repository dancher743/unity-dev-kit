using UnityEngine;

namespace DevKit
{
    public static class Extensions
    {
        #region Unity

        public static void DestroyChildren(this Transform transform)
        {
            for (int i = transform.childCount - 1; i >= 0; i--)
            {
                var child = transform.GetChild(i).gameObject;

                if (Application.isEditor)
                {
                    Object.DestroyImmediate(child);
                }
                else
                {
                    Object.Destroy(child);
                }
            }
        }

        #endregion
    }
}
