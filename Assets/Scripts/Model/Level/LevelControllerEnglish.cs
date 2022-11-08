using Model.Components;
using Model.Static;
using Scriptable;
using UnityEngine;
using Utils;

namespace Model.Level
{
    public class LevelControllerEnglish : LevelControllerBase
    {
        private void OnEnable()
        {
            ClickKey_Action += OnClickAnyKey;
            CustomInput.InputKey_Action += OnClickAnyKey;
        }

        private void OnDisable()
        {
            ClickKey_Action -= OnClickAnyKey;
            CustomInput.InputKey_Action -= OnClickAnyKey;
        }

        private void Start()
        {
            CellKeyboard[] cells = FindObjectsOfType<CellKeyboard>();
            foreach (var cell in cells)
            {
                cell.Setup(this);
            }
        }

        public override void Setup(ModelController modelController, string[] data,
            GameSettings gameSettings)
        {
            ModelController = modelController;
            Data = data;
            GameSettings = gameSettings;
        }

        public override void Restart(bool isRestart)
        {
            CellKeyboard[] cells = FindObjectsOfType<CellKeyboard>();
            foreach (CellKeyboard cell in cells)
            {
                cell.Restart();
            }
            
            if (isRestart)
            {
                GameMetrics.IndexNow = 0;//IndexEnd + 1;
                GameMetrics.IndexEnd = Data.Length;// Random.Range(0, Data.Length);
                ScoreController.Score = 0;
            }
            
            if (GameMetrics.IndexNow == GameMetrics.IndexEnd || GameMetrics.IndexNow >= Data.Length)
            {
                ModelController.Restart(GameTypes.Menu.EndGame);
                return;
            }
            
            GameMetrics.Tries = GameSettings.DefaultTries;
            TriesUI.SetText("Tries: " + GameMetrics.Tries);
            GameMetrics.Word = Data[GameMetrics.IndexNow];
            Debug.Log(GameMetrics.Word);
            WordController.Restart(GameMetrics.Word.Length);
        }
        
        private void OnClickAnyKey(KeyCode key, bool isClick)
        {
            if (!isClick)
                return;

            string k = key.ToString();
            
            if (!GameMetrics.ValidKeys.Contains(k))
                return;
            ClickKey_Action?.Invoke(key, false);

            if (!GameMetrics.Word.Contains(k))
            {
                GameMetrics.Tries--;
                TriesUI.SetText("Tries: " + GameMetrics.Tries);

                if (GameMetrics.Tries <= 0)
                {
                    ModelController.Restart(GameTypes.Menu.GameOver);
                    return;
                }
                return;
            }

            for (int x = 0; x < Data[GameMetrics.IndexNow].Length; x++)
            {
                if (Data[GameMetrics.IndexNow][x] == k[0])
                {
                    WordController.SetVisible(x, k);
                }
            }

            GameMetrics.Word = GameMetrics.Word.Replace(k, "");
            Debug.Log(GameMetrics.Word);

            if (GameMetrics.Word.Length == 0)
            {
                ModelController.Restart(GameMetrics.SetNextTurn(Data, GameSettings) ?
                    GameTypes.Menu.EndGame : GameTypes.Menu.EndLevel);

                ScoreController.Score += GameMetrics.Tries;
                return;
            }
        }
    }
}