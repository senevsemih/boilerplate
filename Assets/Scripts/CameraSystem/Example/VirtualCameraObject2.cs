using Sirenix.OdinInspector;

namespace CameraSystem.Example
{
    public class VirtualCameraObject2 : VirtualCameraBase
    {
        private void Start()
        {
            GetTarget(typeof(Object2));
        }

        [Button]
        public override void ActivateCamera()
        {
            base.ActivateCamera();
        }
    }
}