using UnityEngine;

namespace ViitorCloud {
    public class GizmoTestCase : GizmoBase {
        // Allow the speed of rotation to be changed.
        public float rotationSpeed = 50.0f;

        void OnDrawGizmosSelected() {
            Gizmos.color = new Color(0.75f, 0.0f, 0.0f, 0.75f);

            // Convert the local coordinate values into world
            // coordinates for the matrix transformation.
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawCube(Vector3.zero, Vector3.one);
        }

        // Rotate the cylinder.
        void Update() {
            float zRot = rotationSpeed * Time.deltaTime;
            transform.Rotate(0.0f, 0.0f, zRot);
        }
    }
}