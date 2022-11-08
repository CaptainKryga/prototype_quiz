using TMPro;
using UnityEngine;

namespace View.Game
{
    public class ScoreUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text[] _textScores;

        public void SetScore(int score)
        {
            foreach (var text in _textScores)
            {
                text.text = "Score: " + score.ToString();
            }
        }
    }
}