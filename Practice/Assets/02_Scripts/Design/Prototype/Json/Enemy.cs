using UnityEngine;

namespace Design.Prototype.Json
{
    public class Enemy : MonoBehaviour
    {
        public string name;
        public int basicHealth;
        public int maxHealth;
        public string[] tolerance;
        public string[] weakness;

        public void Initialize(EnemyData data)
        {
            name = data.name;
            basicHealth = data.basicHealth;
            maxHealth = data.maxHealth;
            tolerance = data.tolerance;
            weakness = data.weakness;
        }

        public void PrintStatus()
        {
            Debug.Log($"Name: {name}, Health: {basicHealth}/{maxHealth}");
            Debug.Log($"Tolerance: {string.Join(", ", tolerance)}");
            Debug.Log($"Weakness: {string.Join(", ", weakness)}");
        }
    }
}