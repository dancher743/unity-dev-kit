using UnityEngine;

namespace DevKit
{
    public static class PlayerPrefsExt
    {
        public static bool GetBool(string key, bool defaultValue = false)
        {
            bool value = defaultValue;

            if (PlayerPrefs.HasKey(key))
            {
                var valueAsString = PlayerPrefs.GetString(key);
                value = bool.TryParse(valueAsString, out bool parseResult) ? parseResult : defaultValue;
            }

            return value;
        }

        public static void SetBool(string key, bool value)
        {
            PlayerPrefs.SetString(key, value.ToString());
        }
    }
}
