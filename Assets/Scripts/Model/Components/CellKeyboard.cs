using System;
using Model.Level;
using UnityEngine;
using UnityEngine.UI;

namespace Model.Components
{
    public class CellKeyboard : Cell
    {
        [SerializeField] protected KeyCode _key;
        [SerializeField] private Button _btn;

        public void Setup(LevelControllerBase levelController)
        {
            levelController.ClickKey_Action += ChangeKeyStatus;
            _btn.onClick.AddListener(delegate { levelController.ClickKey_Action?.Invoke(_key, true); });
            Text.text = _key.ToString();
        }

        public void Restart()
        {
            _btn.interactable = true;
            Img.color = Color.white;
        }

        private void ChangeKeyStatus(KeyCode key, bool isClick)
        {
            Debug.Log("FF");
            if (!isClick && key == _key)
            {
                _btn.interactable = false;
                Img.color = Color.grey;
            }
        }
    }
}
