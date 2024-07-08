using UnityEngine;
namespace ViitorCloud {
    public class GizmoMesh : MonoBehaviour {
        [SerializeField] private Mesh _mesh;
        [SerializeField] private bool _wiremesh = false;
        private void OnDrawGizmos() {
            if (_mesh == null) {
                return;
            }
            if (_wiremesh) {
                Gizmos.DrawWireMesh(_mesh, transform.position, transform.rotation, transform.lossyScale);
            } else {
                Gizmos.DrawMesh(_mesh, transform.position, transform.rotation, transform.lossyScale);
            }
        }
    }
}