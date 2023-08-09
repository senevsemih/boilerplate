using System;
using UnityEngine;

namespace Extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 ChangeWith(this Vector3 original, float? x = null, float? y = null, float? z = null)
        {
            var newX = x ?? original.x;
            var newY = y ?? original.y;
            var newZ = z ?? original.z;

            return new Vector3(newX, newY, newZ);
        }

        public static bool IsBehind(this Vector3 queried, Vector3 forward)
        {
            return Vector3.Dot(queried, forward) < 0;
        }

        public static float GetDistanceFrom(this Vector3 vector, Vector3 otherVector)
        {
            return (vector - otherVector).sqrMagnitude;
        }

        public static Vector3 ToGround(this Vector3 vector)
        {
            return new Vector3(vector.x, 0, vector.y);
        }

        public static Vector3 GetClosestVector3From(this Vector3 vector, Vector3[] otherVectors)
        {
            if (otherVectors.Length == 0) throw new Exception("The list of other vectors is empty");

            var minDistance = vector.GetDistanceFrom(otherVectors[0]);
            var minVector = otherVectors[0];

            for (var i = otherVectors.Length - 1; i > 0; i--)
            {
                var newDistance = vector.GetDistanceFrom(otherVectors[i]);

                if (!(newDistance < minDistance)) continue;
                minDistance = newDistance;
                minVector = otherVectors[i];
            }

            return minVector;
        }
    }
}