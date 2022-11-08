using UnityEngine;
using UnityEngine.EventSystems;

namespace Controller.CustomInput
{
    public class CustomInputEnglish : CustomInputBase
    {
        private KeyCode[] list =
        {
            //first
            KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R, KeyCode.T,
            KeyCode.Y, KeyCode.U, KeyCode.I, KeyCode.O, KeyCode.P,
            //second
            KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.J, KeyCode.K, KeyCode.L,
            //third
            KeyCode.Z, KeyCode.X, KeyCode.C, KeyCode.V, KeyCode.B, KeyCode.N, KeyCode.M
        };
        
        protected override void SetupKeyboard()
        {
            for (int x = 0; x < list.Length; x++)
            {
                if (Input.GetKeyDown(list[x]))
                    InputKey_Action?.Invoke(list[x], true);
            }
        }
    }
}