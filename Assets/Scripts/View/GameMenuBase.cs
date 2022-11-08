using Controller;
using UnityEngine;

namespace View
{
    public abstract class GameMenuBase : MonoBehaviour
    {
        [SerializeField] protected ViewController ViewController;
        [SerializeField] private GameObject _panelBase;

        //set active panel
        public void UsePanel(bool flag)
        {
            _panelBase.SetActive(flag);
        }
        
        //restart game(true), next level(false)
        public void OnClick_Restart(bool isRestart)
        {
            UsePanel(false);
            ViewController.Restart(isRestart);
        }
    }
}
