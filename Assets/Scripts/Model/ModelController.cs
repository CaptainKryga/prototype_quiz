using System;
using Model.Level;
using Scriptable;
using UnityEngine;
using Utils;
using View;

namespace Model
{
    public class ModelController: MonoBehaviour
    {
        [SerializeField] private GameSettings _gameSettings;
        
        [SerializeField] private ParserFile _parser;
        [SerializeField] private LevelControllerBase _levelControllerBase;

        [SerializeField] private GameMenuController _gameMenuController;
        
        public void Setup()
        {
            _levelControllerBase.Setup(this, _parser.GetData(_gameSettings.PathInputFile), 
                _gameSettings);
        }

        public void Restart(GameTypes.Menu type)
        {
            _gameMenuController.Restart(type);
        }

        public void Restart(bool isRestart)
        {
            _levelControllerBase.Restart(isRestart);
        }
    }
}