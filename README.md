# Boilerplate

## Camera System

Basic camera `target` and `switch` between cameras system.

```csharp
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
```

```csharp
public class VirtualCameraObject1 : VirtualCameraBase
{
   private void Start()
   {
      GetTarget(typeof(Object1));
   }     

   public override void ActivateCamera()
   {
      base.ActivateCamera();
   }
}
```

## Extensions

The classes are in the `Extensions` namespace, so you must first import them.

### Vector3

```csharp
Vector3 position = transform.position;

position.IsBehind(targetTransform.forward);
position.GetDistanceFrom(targetTransform.position);
position.ToGround();
position.ChangeWith(4,2,0);
```

### List

```csharp
var list = new List<int>() { 1, 2, 3, 4, 5 };
            
list.Shuffle();
list.GetRandomItem();
```

### Collider

```csharp
boxCollider.GetRandomPointInBox();
boxCollider.GetRandomPointInBox(0.5f);
```
