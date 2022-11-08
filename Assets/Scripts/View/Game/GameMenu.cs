using UnityEngine;

namespace View.Game
{
    public class GameMenu: GameMenuBase
    {
        [SerializeField] private GameMenuBase _mainMenu;

        //return menu
        public void OnClick_Back()
        {
            UsePanel(false);
            _mainMenu.UsePanel(true);
        }
    }
}