using UnityEngine;

namespace CameraSystem.Interfaces
{
    public interface ICameraTarget
    {
        public Transform Transform { get; }

        void SubToCamera();
        void UnSubToCamera();
    }
}