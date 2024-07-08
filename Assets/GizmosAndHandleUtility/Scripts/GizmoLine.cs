using UnityEngine;

namespace ViitorCloud {
    public class GizmoLine : GizmoBase {
        [SerializeField][Range(0, 100)] private float _distance = 5f;

        private void OnDrawGizmos() {            
            //Example to Draw Line from Given Position to Target Position using given distance
            DrawLine(transform.position, Vector3.forward, _distance);            
        }

        private void OnDrawGizmosSelected() {           
        
        }

        private void DrawLine(Vector3 from, Vector3 to, float distance = 1f) {
            Gizmos.color = _color;
            Vector3 direction = transform.TransformDirection(to) * distance;
            Gizmos.DrawRay(from, direction);
        }
    }//GizmoLine class end.
}