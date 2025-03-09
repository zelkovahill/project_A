using UnityEngine;

namespace Design.Prototype.Instantiate
{
    public class Enemy : MonoBehaviour
    {
        public string enemyName;
        public int health;

        public void Initialize(string name, int hp)
        {
            enemyName = name;
            health = hp;
        }

        public void PrintStatus()
        {
            Debug.Log($"Name: {enemyName}, Health: {health}");
        }
    }
}
