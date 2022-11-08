using Scriptable;

namespace Model.Level
{
    public class LevelControllerEnglish : LevelControllerBase
    {
        public override void Setup(string[] data, GameSettings gameSettings)
        {
            Data = data;
            GameSettings = gameSettings;
            Index = 0;
            ScoreController.Score = 0;
        }

        public override void Restart(bool isRestart)
        {
            if (isRestart)
            {
                ScoreController.Score = 0;
            }
        }
    }
}