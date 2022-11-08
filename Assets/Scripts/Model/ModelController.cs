using Model.Level;
using Scriptable;
using UnityEngine;

namespace Model
{
    public class ModelController: MonoBehaviour
    {
        [SerializeField] private GameSettings _gameSettings;
        
        [SerializeField] private ParserFile _parser;
        [SerializeField] private LevelControllerBase _levelControllerBase;
        
        public void Setup()
        {
            _levelControllerBase.Setup(this, _parser.GetData(_gameSettings.PathInputFile), _gameSettings);
        }
    }
}