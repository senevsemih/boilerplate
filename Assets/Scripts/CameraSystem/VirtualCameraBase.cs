using System;
using CameraSystem.Interfaces;
using Cinemachine;
using UnityEngine;

namespace CameraSystem
{
    public class VirtualCameraBase : MonoBehaviour, IVirtualCamera
    {
        private const float BLEND_DURATION = 1f;

        public ICameraTarget CameraTarget { get; set; }
        public CinemachineVirtualCamera Camera { get; private set; }

        private void Awake() => Camera = GetComponent<CinemachineVirtualCamera>();

        private void OnEnable()
        {
            if (CameraManager.Instance == null) return;
            CameraManager.Instance.AddCamera(this);
        }

        private void OnDisable()
        {
            if (CameraManager.Instance == null) return;
            CameraManager.Instance.RemoveCamera(this);
        }

        public virtual void GetTarget(Type type)
        {
            CameraTarget = CameraManager.Instance.GetCameraTarget(type);
            SetTargetValues(CameraTarget);
        }

        public virtual void ActivateCamera() => CameraManager.Instance.ActivateCamera(this, BLEND_DURATION);

        private void SetTargetValues(ICameraTarget cameraTarget)
        {
            Camera.Follow = cameraTarget.Transform;
            Camera.LookAt = cameraTarget.Transform;
        }
    }
}