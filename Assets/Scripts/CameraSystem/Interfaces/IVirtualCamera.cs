using System;
using Cinemachine;

namespace CameraSystem.Interfaces
{
    public interface IVirtualCamera
    {
        public ICameraTarget CameraTarget { get; set; }
        public CinemachineVirtualCamera Camera { get; }

        void GetTarget(Type type);
        void ActivateCamera();
    }
}