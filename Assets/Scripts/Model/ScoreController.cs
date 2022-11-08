using UnityEngine;
using View.Game;

namespace Model
{
    public class ScoreController: MonoBehaviour
    {
        [SerializeField] private ScoreUI _scoreUI;

        private int _score;

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                _scoreUI.SetScore(_score);
            }
        }
    }
}