using System;
using Model.Components;
using Scriptable;
using Random = UnityEngine.Random;

namespace Model.Level
{
    public class LevelControllerEnglish : LevelControllerBase
    {
        private void Start()
        {
            Cell[] cells = FindObjectsOfType<Cell>();
            foreach (var cell in cells)
            {
                cell.Setup(ClickKey_Action);
            }
        }

        public override void Setup(ModelController modelController, string[] data, GameSettings gameSettings)
        {
            ModelController = modelController;
            Data = data;
            GameSettings = gameSettings;
            IndexStart = Random.Range(0, Data.Length);
            Index = IndexStart + 1;
            ScoreController.Score = 0;
        }

        public override void Restart(bool isRestart)
        {
            if (isRestart)
            {
                ScoreController.Score = 0;
                IndexStart = Random.Range(0, Data.Length);
                Index = IndexStart + 1;
            }
            
            StartLevel();
        }

        private void StartLevel()
        {
            
        }
    }
}