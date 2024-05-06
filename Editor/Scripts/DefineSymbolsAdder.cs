using DevKit.Constants;
using DevKit.Debugging;
using DevKit.Editors.Constants;
using System.Linq;
using UnityEditor;

namespace DevKit.Editors
{
    public static class DefineSymbolsAdder
    {
        private static readonly string[] SymbolsToAdd = new[] {
            DefineSymbols.EnableDebugLog
        };

        [InitializeOnLoadMethod]
        private static void OnLoad()
        {
            if (!EditorPrefs.GetBool(EditorPrefsKeys.DefineSymbolsAddedKey, false))
            {
                AddDefineSymbols();
                EditorPrefs.SetBool(EditorPrefsKeys.DefineSymbolsAddedKey, true);
            }
        }

        [MenuItem(EditorPaths.MenuItems.AddDefineSymbolsItem)]
        public static void AddDefineSymbols()
        {
            var defineSymbolsAsString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
            var defineSymbolsAsList = defineSymbolsAsString.Split(';').ToList();

            defineSymbolsAsList.AddRange(SymbolsToAdd.Except(defineSymbolsAsList));

            PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup,
                string.Join(";", defineSymbolsAsList.ToArray()));

            ConsoleLogger.Log("Define Symbols from Dev Kit added successfully to the Player Settings.");
        }
    }
}
