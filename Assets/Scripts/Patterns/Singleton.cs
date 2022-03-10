using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TinyTools.Pattern
{
    /// <summary>
    /// Singleton Pattern
    /// using like this: YourClass : Singleton<YourClass>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject();
                        _instance = obj.AddComponent<T>();
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// On awake, initialize the instance. Call base.Awake() in override if you need to using awake
        /// </summary>
        protected virtual void Awake()
        {
            if (!Application.isPlaying)
            {
                return;
            }

            _instance = this as T;
        }
    }
}
