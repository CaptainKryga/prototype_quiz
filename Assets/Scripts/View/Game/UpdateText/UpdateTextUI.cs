using TMPro;
using UnityEngine;

namespace View.Game.UpdateText
{
    public class UpdateTextUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text[] _textScores;

        public void SetText(string str)
        {
            foreach (var text in _textScores)
            {
                text.text = str;
            }
        }
    }
}
