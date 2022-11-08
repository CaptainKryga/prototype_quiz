using Scriptable;

namespace Model.Static
{
    public static class GameMetrics
    {
        public static string[] Data;
        private static string _validKeys = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private static string _useKeys;

        public static bool CheckValidKey(string key)
        {
            if (!_validKeys.Contains(key) || _useKeys.Contains(key))
            {
                return false;
            }

            _useKeys += key;
            return true;
        }

        public static void Restart()
        {
            _useKeys = "";
        }
    }
}
