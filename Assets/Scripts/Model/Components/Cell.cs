using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Model.Components
{
    public abstract class Cell : MonoBehaviour
    {
        [SerializeField] protected Image Img;
        [SerializeField] protected TMP_Text Text;
    }
}
