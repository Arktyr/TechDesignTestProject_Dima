using UnityEngine;
using UnityEngine.UI;

namespace CodeBase
{
    public class UiView : MonoBehaviour
    {
        [SerializeField] private Button _button;

        public void EnableButton() => 
            _button.gameObject.SetActive(true);
    }
}