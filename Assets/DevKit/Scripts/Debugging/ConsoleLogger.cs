using DevKit.Constants;
using System.Diagnostics;

namespace DevKit.Debugging
{
    public static class ConsoleLogger
    {
        [Conditional(DefineSymbols.EnableDebugLog)]
        public static void Log(object message)
        {
            UnityEngine.Debug.Log(message);
        }

        [Conditional(DefineSymbols.EnableDebugLog)]
        public static void LogWarning(object message)
        {
            UnityEngine.Debug.LogWarning(message);
        }

        [Conditional(DefineSymbols.EnableDebugLog)]
        public static void LogError(object message)
        {
            UnityEngine.Debug.LogError(message);
        }
    }
}
