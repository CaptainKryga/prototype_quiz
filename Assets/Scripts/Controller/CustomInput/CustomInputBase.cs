using System;
using UnityEngine;

namespace Controller.CustomInput
{
    public abstract class CustomInputBase : MonoBehaviour
    {
        public Action<KeyCode, bool> InputKey_Action;
        
        private void Update()
        {
            SetupKeyboard();
        }
        
        protected abstract void SetupKeyboard();
    }
}