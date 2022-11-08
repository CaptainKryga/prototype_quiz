using TMPro;
using UnityEngine;

namespace View.Game
{
    public class ScoreUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textScore;

        public void SetScore(int score)
        {
            _textScore.text = "Score: " + score.ToString();
        }
    }
}