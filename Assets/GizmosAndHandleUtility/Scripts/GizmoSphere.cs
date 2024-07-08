using UnityEngine;

namespace ViitorCloud {
    public class GizmoSphere : MonoBehaviour {      
        [SerializeField] [Range(0, 1)] private float _radius = 0.5f;

        private void OnDrawGizmosSelected() {

        }

        private void OnDrawGizmos() {
            // Draw a yellow sphere at the transform's position
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(transform.position, _radius);
        }       
    }
}
