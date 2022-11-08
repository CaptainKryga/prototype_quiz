using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Model.Components
{
    public class Cell : MonoBehaviour
    {
        [SerializeField] private Image _img;
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Button _btn;
        [SerializeField] private KeyCode _key;

        public void Setup(Action<KeyCode> action)
        {
            action += ChangeKeyStatus;
            _btn.onClick.AddListener(delegate { action?.Invoke(_key); });
            _text.text = _key.ToString();
        }

        private void ChangeKeyStatus(KeyCode key)
        {
            if (key == _key)
            {
                _btn.interactable = false;
                _img.color = Color.grey;
            }
        }
    }
}
