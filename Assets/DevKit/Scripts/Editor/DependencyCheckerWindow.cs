using DevKit.Constants;
using UnityEditor;
using UnityEngine;

namespace DevKit.Editors
{
    public class DependencyCheckerWindow : EditorWindow
    {
        [MenuItem(Paths.Menu.DependencyChecker)]
        public static void ShowWindow()
        {
            var checkerWindow = GetWindow<DependencyCheckerWindow>();
            checkerWindow.titleContent = new GUIContent("Dependency Checker");
        }

        private void OnGUI()
        {
            bool isInstalled;

            isInstalled = AssetDatabase.FindAssets("NaughtyAttributes.Core").Length > 0;
            AddItem("NaughtyAttributes", isInstalled, "https://assetstore.unity.com/packages/tools/utilities/naughtyattributes-129996");

            isInstalled = AssetDatabase.FindAssets("DOTween.dll").Length > 0;
            AddItem("DOTween", isInstalled, "https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676");
        }

        private void AddItem(string name, bool isInstalled, string url)
        {
            GUILayout.BeginHorizontal();

            var iconName = !isInstalled ? "circle_red_checkmark" : "circle_green_checkmark";
            var icon = Resources.Load<Texture>("Editor/" + iconName);
            GUILayout.Label(icon);

            GUILayout.Label(name);

            var options = new GUILayoutOption[] { GUILayout.ExpandWidth(false) };
            if (!isInstalled)
            {
                if (GUILayout.Button("Install", options))
                {
                    Application.OpenURL(url);
                }
            }
            else
            {
                GUILayout.Label("Installed", options);
            }

            GUILayout.EndHorizontal();
        }
    }
}
