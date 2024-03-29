using DevKit.Constants;
using DevKit.Debugging;
using System.Linq;
using UnityEditor;

namespace DevKit.Editors
{
    public static class DefineSymbolsAdder
    {
        private static readonly string[] SymbolsToAdd = new[] {
            DefineSymbols.EnableDebugLog
        };

        [MenuItem(Paths.Menu.AddDefineSymbols)]
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
