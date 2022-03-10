using UnityEngine;

namespace TinyTools.Pattern {
    /// <summary>
    /// Persistent singleton
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PersistentSingleton<T> : MonoBehaviour where T : Component
    {
        protected static T _instance;
        protected bool _enabled;

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
        /// also, check if there is any instance in the scene, if there is one, destroy it
        /// </summary>
        protected virtual void Awake()
        {
            if (!Application.isPlaying)
            {
                return;
            }

            if (_instance == null)
            {
                // If this is the first instance in the scene, make it Singleton
                _instance = this as T;
                DontDestroyOnLoad(transform.gameObject);
                _enabled = true;
            }
            else
            {
                // if a Singleton already exists and there is another reference in scene, destroy it
                if (this != _instance)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}

