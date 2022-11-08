using Scriptable;
using UnityEngine;

namespace Model
{
    public class ModelController: MonoBehaviour
    {
        [SerializeField] private GameSettings _gameSettings;
        
        [SerializeField] private ParserFile _parser;
        public void Setup()
        {
            string[] f = _parser.GetData(_gameSettings.PathInputFile);
            Debug.Log(f.Length);
        }
    }
}