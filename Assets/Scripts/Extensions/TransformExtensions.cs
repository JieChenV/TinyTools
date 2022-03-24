using UnityEngine;

namespace TinyTools.Extensions
{
    /// <summary>
    /// Extention methonds for Transform
    /// </summary>
    public static class TransformExtensions
    {
        /// <summary>
        /// Set the position of X
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x"> x value </param>
        /// <returns> new position </returns>
        public static Vector3 SetPosistionX(this Transform t, float x)
        {
            t.position = t.position.SetX(x);
            return t.position;
        }

        /// <summary>
        /// Set the position of Y
        /// </summary>
        /// <param name="t"></param>
        /// <param name="y"> y value </param>
        /// <returns> new position  </returns>
        public static Vector3 SetPosistionY(this Transform t, float y)
        {
            t.position = t.position.SetY(y);
            return t.position;
        }

        /// <summary>
        /// Set the position of Z
        /// </summary>
        /// <param name="t"></param>
        /// <param name="z"> z value </param>
        /// <returns> new position </returns>
        public static Vector3 SetPosistionZ(this Transform t, float z)
        {
            t.position = t.position.SetZ(z);
            return t.position;
        }



        /// <summary>
        /// Set the local position of x
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x"> x value  </param>
        /// <returns> new local position </returns>
        public static Vector3 SetLocalPositionX(this Transform t, float x)
        {
            t.localPosition = t.localPosition.SetX(x);
            return t.localPosition;
        }

        /// <summary>
        /// Set the local position of y
        /// </summary>
        /// <param name="t"></param>
        /// <param name="y"> y value  </param>
        /// <returns> new local position </returns>
        public static Vector3 SetLocalPositionY(this Transform t, float y)
        {
            t.localPosition = t.localPosition.SetY(y);
            return t.localPosition;
        }

        /// <summary>
        /// Set the local position of x
        /// </summary>
        /// <param name="t"></param>
        /// <param name="z"> z value  </param>
        /// <returns> new local position </returns>
        public static Vector3 SetLocalPositionZ(this Transform t, float z)
        {
            t.localPosition = t.localPosition.SetZ(z);
            return t.localPosition;
        }

        /// <summary>
        /// Set localScale's x only
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x"> x value </param>
        /// <returns> new localScale </returns>
        public static Vector3 SetLocalScaleX(this Transform t, float x) {
            t.localScale = t.localScale.SetX(x);
            return t.localScale;
        }

        /// <summary>
        /// Flip localScale around X axis 
        /// </summary>
        /// <param name="t"></param>
        /// <returns> new localScale </returns>
        public static Vector3 FlipXAxis(this Transform t) {
            t.localScale = t.localScale.SetX(-t.localScale.x);
            return t.localScale;
        }


        /// <summary>
        /// Flip localScale around Y axis
        /// </summary>
        /// <param name="t"></param>
        /// <returns> new localScale </returns>
        public static Vector3 FlipYAxis(this Transform t)
        {
            t.localScale = t.localScale.SetY(-t.localScale.y);
            return t.localScale;
        }

        /// <summary>
        /// Flip localScale around Z axis
        /// </summary>
        /// <param name="t"></param>
        /// <returns> new localScale </returns>
        public static Vector3 FlipZAxis(this Transform t)
        {
            t.localScale = t.localScale.SetZ(-t.localScale.z);
            return t.localScale;
        }
    }
}
