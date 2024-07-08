using UnityEngine;

namespace ViitorCloud {
    public class GizmoCube : GizmoBase{

        [SerializeField]
        private Vector3 _scale = Vector3.one;

        private void OnDrawGizmos() {
            // Draw a yellow cube at the transform's position
            Gizmos.color = _color;
            Gizmos.DrawCube(transform.position, _scale);
        }
    }
}