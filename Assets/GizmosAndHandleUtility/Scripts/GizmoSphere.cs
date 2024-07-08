using UnityEngine;

namespace ViitorCloud {
    public class GizmoSphere : GizmoBase {
        [SerializeField][Range(0, 1)] private float _radius = 0.5f;
        [SerializeField] private bool _wireSpere = false;

        private void OnDrawGizmosSelected() {

        }

        private void OnDrawGizmos() {
            Gizmos.color = _color;
            if (_wireSpere) {
                Gizmos.DrawWireSphere(transform.position, _radius);
            } else {
                Gizmos.DrawSphere(transform.position, _radius);
            }
        }
    }
}
