using Scriptable;

namespace Model.Static
{
    public static class GameMetrics
    {
        public static string[] Data;
        private static string ValidKeys = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private static string UseKeys;

        public static bool CheckValidKey(string key)
        {
            if (!ValidKeys.Contains(key) || UseKeys.Contains(key))
            {
                return false;
            }

            UseKeys += key;
            return true;
        }

        public static void Restart()
        {
            UseKeys = "";
        }
    }
}
