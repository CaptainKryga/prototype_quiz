using System;
using Model.Components;
using UnityEngine;

namespace Model
{
    public class WordController : MonoBehaviour
    {
        [SerializeField] private Cell _prefabCell;
        [SerializeField] private Transform parent;

        private Cell[] _word;

        public void Restart(int length)
        {
            if (_word != null && _word.Length > 0)
            {
                for (int x = 0; x < _word.Length; x++)
                {
                    Destroy(_word[x].gameObject);
                }
            }
            
            _word = new Cell[length];
            int startX = -length * 100 / 2;
            for (int x = 0; x < length; x++)
            {
                _word[x] = Instantiate(_prefabCell, 
                    parent.position + Vector3.right * startX + Vector3.right * x * 100,
                    Quaternion.identity, parent);
            }
        }

        public void SetVisible(int index, string word)
        {
            ((CellField)_word[index]).Setup(word);
        }
    }
}
