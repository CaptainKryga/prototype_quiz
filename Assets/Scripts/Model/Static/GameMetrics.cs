using Scriptable;

namespace Model.Static
{
    public static class GameMetrics
    {
        public static int IndexNow, IndexEnd, Tries;
        public static string ValidKeys = "QWERTYUIOPASDFGHJKLZXCVBNM", Word;
        
        public static bool SetNextTurn(string[] data, GameSettings gameSettings)
        {
            for (int x = IndexNow + 1; x < data.Length; x++)
            {
                if (x == IndexEnd)
                    return true;

                if (data[x].Length >= gameSettings.MinWordLength)
                {
                    IndexNow = x;
                    return false;
                }
                
                if (x + 1 == data.Length)
                    x = -1;
            }

            return false;
        }
    }
}
