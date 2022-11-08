using Controller;
using UnityEngine;
using Utils;

namespace View
{
    public abstract class GameMenuBase : MonoBehaviour
    {
        [SerializeField] protected GlobalController GlobalController;
        [SerializeField] private GameObject _panelBase;
        public GameTypes.Menu Type;

        //set active panel
        public void UsePanel(bool flag)
        {
            _panelBase.SetActive(flag);
        }
        
        //restart game(true), next level(false)
        public void OnClick_Restart(bool isRestart)
        {
            UsePanel(false);
            GlobalController.Restart(isRestart);
        }
    }
}
