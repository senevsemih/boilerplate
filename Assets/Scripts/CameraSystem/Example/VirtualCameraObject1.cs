using Sirenix.OdinInspector;

namespace CameraSystem.Example
{
    public class VirtualCameraObject1 : VirtualCameraBase
    {
        private void Start()
        {
            GetTarget(typeof(Object1));
        }
        
        [Button]
        public override void ActivateCamera()
        {
            base.ActivateCamera();
        }
    }
}