using UnityEngine;

namespace Design.Prototype.Instantiate
{
    public class EnemySpawner : MonoBehaviour
    {
        public GameObject enemyPrefab;

        private void Start()
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject newEnemy = Instantiate(enemyPrefab);
                Enemy enemyScript = newEnemy.GetComponent<Enemy>();
                enemyScript.Initialize("고블린 " + i, 50);
                enemyScript.PrintStatus();
                newEnemy.transform.position = new Vector3(i * 2, 0, 0);
            }
        }
    }
}