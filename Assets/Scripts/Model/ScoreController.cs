using UnityEngine;
using View.Game.UpdateText;

namespace Model
{
    public class ScoreController: MonoBehaviour
    {
        [SerializeField] private UpdateTextUI _scoreUI;

        private int _score;

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                _scoreUI.SetText("Score: " + _score);
            }
        }
    }
}