using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ViitorCloud {
    public class GizmoLines : GizmoBase {
        private Vector3[] points;

        [SerializeField]
        private List<Transform> _transforms = new List<Transform>();

        [SerializeField]
        private bool _closeLoop = false; // New boolean to close the loop

        void Start() {
            UpdatePoints();
        }

        void Update() {
            // Uncomment if you want to automatically update points each frame
            UpdatePoints();
        }

        void OnDrawGizmos() {
            // Draws two parallel blue lines
            Gizmos.color = _color;
            DrawLineList(points);
            DrawLabels(points);
        }

        // Custom method to draw a list of points as lines
        private void DrawLineList(Vector3[] points) {
            if (points == null || points.Length < 2)
                return;

            for (int i = 0; i < points.Length - 1; i++) {
                Gizmos.DrawLine(points[i], points[i + 1]);
            }

            // If closeLoop is true, draw a line from the last point to the first point
            if (_closeLoop && points.Length > 1) {
                Gizmos.DrawLine(points[points.Length - 1], points[0]);
            }
        }

        // Method to draw labels at each point
        private void DrawLabels(Vector3[] points) {
            if (points == null)
                return;

            for (int i = 0; i < points.Length; i++) {
                Handles.Label(points[i], $"P:{i}");
            }
        }

        // Public method to update the points array
        public void UpdatePoints() {
            if (_transforms == null || _transforms.Count == 0)
                return;

            points = new Vector3[_transforms.Count];
            for (int i = 0; i < _transforms.Count; i++) {
                points[i] = _transforms[i].position;
            }
        }
    }
}
