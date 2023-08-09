using Cinemachine;
using UnityEngine;

namespace CameraSystem
{
    public class CameraBrain : MonoBehaviour
    {
        public CinemachineBrain CinemachineBrain { get; private set; }

        private void Awake() => CinemachineBrain = GetComponent<CinemachineBrain>();

        private void OnEnable()
        {
            if (CameraManager.Instance == null) return;
            CameraManager.Instance.SetCameraBrain(this);
        }
    }
}