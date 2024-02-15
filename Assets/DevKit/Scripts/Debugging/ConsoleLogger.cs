using System.Diagnostics;

namespace DevKit.Debugging
{
    public static class ConsoleLogger
    {
        [Conditional("ENABLE_LOG")]
        public static void Log(object message)
        {
            UnityEngine.Debug.Log(message);
        }
    }
}
