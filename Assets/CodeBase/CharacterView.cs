using UnityEngine;

namespace CodeBase
{
    [RequireComponent(typeof(Animator))]
    public class CharacterView : MonoBehaviour
    {
        private Animator _animator;
    
        private void Start() => 
            _animator = gameObject.GetComponent<Animator>();
    
        private readonly int IsClicked = Animator.StringToHash("IsClicked");

        public void PlayAnimation() => 
            _animator.SetTrigger(IsClicked);
    }
}