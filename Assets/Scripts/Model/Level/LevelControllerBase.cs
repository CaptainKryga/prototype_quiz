using Scriptable;
using UnityEngine;

namespace Model.Level
{
    public abstract class LevelControllerBase: MonoBehaviour
    {
        [SerializeField] protected ScoreController ScoreController;
        protected GameSettings GameSettings;
        
        protected string[] Data;
        protected int Index;
        protected int Tries;

        public abstract void Setup(string[] data, GameSettings gameSettings);
        public abstract void Restart(bool isRestart);
    }
}