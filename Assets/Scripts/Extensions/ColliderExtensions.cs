using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Extensions
{
    public static class ColliderExtensions
    {
        public static Vector3 GetRandomPointInBox(this BoxCollider box, float t = 0f)
        {
            if (t is < 0 or > 1) throw new Exception("Interpolate value needs to be 0-1 range");

            var extents = box.size / 2f;
            var newExtents = Vector3.Lerp(extents, Vector3.zero, t);

            var point = new Vector3(
                Random.Range(-newExtents.x, newExtents.x),
                Random.Range(-newExtents.y, newExtents.y),
                Random.Range(-newExtents.z, newExtents.z)
            ) + box.center;

            return box.transform.TransformPoint(point);
        }
    }
}