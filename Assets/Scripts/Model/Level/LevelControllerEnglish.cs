using Model.Components;
using Model.Static;
using Scriptable;
using UnityEngine;
using Utils;

namespace Model.Level
{
    public class LevelControllerEnglish : LevelControllerBase
    {
        private CellKeyboard[] _cells;
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
            _cells = FindObjectsOfType<CellKeyboard>();
            foreach (var cell in _cells)
            {
                cell.Setup(this);
            }
        }

        public override void Setup(ModelController modelController, GameSettings gameSettings)
        {
            ModelController = modelController;
            GameSettings = gameSettings;
        }

        public override void Restart(bool isRestart)
        {
            foreach (CellKeyboard cell in _cells)
            {
                cell.Restart();
            }
            
            if (isRestart)
            {
                IndexNow = 0;//IndexEnd + 1;
                IndexEnd = GameMetrics.Data.Length;// Random.Range(0, Data.Length);
                ScoreController.Score = 0;
            }
            
            if (IndexNow == IndexEnd || IndexNow >= GameMetrics.Data.Length)
            {
                ModelController.Restart(GameTypes.Menu.EndGame);
                return;
            }

            GameMetrics.Restart();
            
            Tries = GameSettings.DefaultTries;
            TriesUI.SetText("Tries: " + Tries);
            Word = GameMetrics.Data[IndexNow];
            WordController.Restart(Word.Length);
            
            Debug.Log(Word);
        }
        
        private void OnClickAnyKey(KeyCode key, bool isClick)
        {
            if (!isClick)
                return;

            //check valid key
            string k = key.ToString();
            if (!GameMetrics.CheckValidKey(k))
                return;
            
            ClickKey_Action?.Invoke(key, false);

            //check on error's
            if (!Word.Contains(k))
            {
                Tries--;
                TriesUI.SetText("Tries: " + Tries);

                if (Tries <= 0)
                {
                    ModelController.Restart(GameTypes.Menu.GameOver);
                    return;
                }
                return;
            }

            //update word in dream field
            WordController.SetVisible(IndexNow, k);
            Word = Word.Replace(k, "");
            Debug.Log(Word);

            //if the word is guessed
            if (Word.Length == 0)
            {
                ModelController.Restart(SetNextTurn(GameMetrics.Data, GameSettings) ?
                    GameTypes.Menu.EndGame : GameTypes.Menu.EndLevel);

                ScoreController.Score += Tries;
                return;
            }
        }
        
        private bool SetNextTurn(string[] data, GameSettings gameSettings)
        {
            for (int x = IndexNow; x < data.Length;)
            {
                x++;
                
                if (x >= IndexEnd)
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