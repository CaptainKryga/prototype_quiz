using System;
using Scriptable;
using UnityEngine;

namespace Model.Level
{
    public abstract class LevelControllerBase: MonoBehaviour
    {
        protected ModelController ModelController;
        [SerializeField] protected ScoreController ScoreController;
        protected GameSettings GameSettings;
        
        protected string[] Data;
        protected int Index, IndexStart;
        protected int Tries;

        protected Action<KeyCode> ClickKey_Action;

        public abstract void Setup(ModelController modelController, string[] data, GameSettings gameSettings);
        public abstract void Restart(bool isRestart);
    }
}