using CameraSystem.Interfaces;
using UnityEngine;

namespace CameraSystem.Example
{
    public class Object1 : MonoBehaviour, ICameraTarget
    {
        public Transform Transform => transform;

        private void OnEnable()
        {
            if (CameraManager.Instance == null) return;
            SubToCamera();
        }

        private void OnDisable()
        {
            if (CameraManager.Instance == null) return;
            UnSubToCamera();
        }

        public void SubToCamera() => CameraManager.Instance.AddCameraTarget(this);
        public void UnSubToCamera() => CameraManager.Instance.RemoveCameraTarget(this);
    }
}