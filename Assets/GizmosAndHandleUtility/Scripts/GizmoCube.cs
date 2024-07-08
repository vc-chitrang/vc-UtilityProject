using UnityEngine;

namespace ViitorCloud {
    public class GizmoCube : GizmoBase {

        [SerializeField]
        private Vector3 _scale = Vector3.one;
        [SerializeField] private bool _wireCube = false;
        private void OnDrawGizmos() {
            Gizmos.color = _color;
            if (_wireCube) {
                Gizmos.DrawWireCube(transform.position, _scale);
            } else {
                Gizmos.DrawCube(transform.position, _scale);
            }
        }
    }
}