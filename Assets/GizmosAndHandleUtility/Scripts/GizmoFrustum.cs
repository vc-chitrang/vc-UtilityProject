using UnityEngine;

namespace ViitorCloud {
    public class GizmoFrustum : MonoBehaviour {
        [SerializeField][Range(0, 100)] private float _fov = 60f;
        [SerializeField][Range(0, 1)] private float _min = 0f;
        [SerializeField][Range(0, 1000)] private float _max = 100f;

        private const float MIN_ASPECT_RATIO = 1.33f; // Example: 4:3 aspect ratio
        private const float MAX_ASPECT_RATIO = 1.78f; // Example: 16:9 aspect ratio
        [SerializeField][Range(MIN_ASPECT_RATIO, MAX_ASPECT_RATIO)] private float _aspect = MAX_ASPECT_RATIO;
        private void OnDrawGizmos() {
            Gizmos.DrawFrustum(transform.position, _fov, _max, _min, _aspect);
        }
    }
}