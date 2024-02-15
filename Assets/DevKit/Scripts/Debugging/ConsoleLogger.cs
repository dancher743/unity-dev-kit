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
    }
}
