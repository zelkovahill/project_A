using UnityEngine;

namespace Design.Singleton
{
    public class SingletonAsComponent<T> : MonoBehaviour where T : SingletonAsComponent<T>
    {
        private static T s_Instance;

        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = FindFirstObjectByType<T>();

                    if (s_Instance == null)
                    {
                        GameObject singletonObject = new GameObject();
                        s_Instance = singletonObject.AddComponent<T>();

                        singletonObject.name = typeof(T).ToString();

                        DontDestroyOnLoad(singletonObject);
                    }
                }
                return s_Instance;
            }
        }

        protected virtual void Awake()
        {
            if (s_Instance is null)
            {
                s_Instance = this as T;
                DontDestroyOnLoad(this.gameObject);
            }
            else if (s_Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}