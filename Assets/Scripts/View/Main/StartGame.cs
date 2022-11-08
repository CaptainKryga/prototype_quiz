using UnityEngine;

namespace View.Main
{
    public class StartGame : GameMenuBase
    {
        //quit
        public virtual void OnClick_Exit()
        {
            Application.Quit();
        }
    }
}