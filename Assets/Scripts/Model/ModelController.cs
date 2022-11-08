using UnityEngine;

namespace Model
{
    public class ModelController: MonoBehaviour
    {
        [SerializeField] private ParserFile _parser;
        public void Setup()
        {
            _parser.GetData();
        }
    }
}