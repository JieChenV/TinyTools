
using UnityEngine;

namespace TinyTools.Extensions
{
    /// <summary>
    /// Extensions methods to the Unity Vector3
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        /// Set x of the Vector3
        /// </summary>
        /// <param name="v"></param>
        /// <param name="x"> new x </param>
        /// <returns> new Vector3 </returns>
        public static Vector3 SetX(this Vector3 v, float x)
        {
            return new Vector3(x, v.y, v.z);
        }

        /// <summary>
        /// Set y of the Vector3
        /// </summary>
        /// <param name="v"></param>
        /// <param name="y"></param>
        /// <returns>  new Vector3  </returns>
        public static Vector3 SetY(this Vector3 v, float y)
        {
            return new Vector3(v.x, y, v.z);
        }

        /// <summary>
        /// Set z of the Vector3
        /// </summary>
        /// <param name="v"></param>
        /// <param name="z"></param>
        /// <returns> new Vector3 </returns>
        public static Vector3 SetZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }

        /// <summary>
        /// Round the Vector3
        /// </summary>
        /// <param name="v"></param>
        /// <returns> new Vector3 </returns>
        public static Vector3 Round(this Vector3 v) {
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            v.z = Mathf.Round(v.z);

            return v;
        }


    }
}

