using UnityEngine;
using Utils;

namespace View
{
    public class GameMenuController: MonoBehaviour
    {
        [SerializeField] private GameMenuBase[] _menus;

        public void Restart(GameTypes.Menu type)
        {
            for (int x = 0; x < _menus.Length; x++)
            {
                if (_menus[x].Type == type)
                    _menus[x].UsePanel(true);
            }
        }
    }
}