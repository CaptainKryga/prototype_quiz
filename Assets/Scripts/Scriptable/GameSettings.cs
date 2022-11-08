using UnityEngine;

namespace Scriptable
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings", order = 1)]
    public class GameSettings : ScriptableObject
    {
        public string PathInputFile;
        [Min(1)]
        public int MinWordLength;
        [Min(1)]
        public int DefaultTries;
    }
}
