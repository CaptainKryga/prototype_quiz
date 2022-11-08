using System;
using Controller.CustomInput;
using Scriptable;
using UnityEngine;
using View.Game.UpdateText;

namespace Model.Level
{
    public abstract class LevelControllerBase: MonoBehaviour
    {
        protected ModelController ModelController;
        [SerializeField] protected ScoreController ScoreController;
        [SerializeField] protected UpdateTextUI TriesUI;
        protected GameSettings GameSettings;
        [SerializeField] protected CustomInputBase CustomInput;
        [SerializeField] protected WordController WordController;
        
        public static int IndexNow, IndexEnd, Tries;
        public static string Word;

        //key, isClick
        public Action<KeyCode, bool> ClickKey_Action;

        public abstract void Setup(ModelController modelController, GameSettings gameSettings);
        public abstract void Restart(bool isRestart);
    }
}