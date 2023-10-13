using UnityEngine;

namespace CodeBase
{
    public class Interactor : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
    
        private void Update()
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

                Vector2 origin = new Vector2(ray.origin.x, ray.origin.y);
                Vector2 direction = new Vector2(ray.direction.x, ray.direction.y);

                RaycastObjects(origin, direction);
            }
        }

        private void RaycastObjects(Vector2 origin, Vector2 direction)
        {
            RaycastHit2D raycastHit2D = Physics2D.Raycast(origin, direction);
            
            if (raycastHit2D.collider == null) return;

            if (raycastHit2D.collider.TryGetComponent(out CharacterView characterView))
                characterView.PlayAnimation();
            
            if (raycastHit2D.collider.TryGetComponent(out UiView uiView))
                uiView.EnableButton();
        }
    }
}
