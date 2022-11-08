using UnityEngine;

namespace Scriptable
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings", order = 1)]
    public class GameSettings : ScriptableObject
    {
        public string PathInputFile;
        public int MinWordLength;
        public int DefaultTries;
    }
}
