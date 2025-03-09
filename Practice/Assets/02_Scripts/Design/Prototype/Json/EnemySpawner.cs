using UnityEngine;

namespace Design.Prototype.Json
{
    public class EnemySpawner : MonoBehaviour
    {
        public GameObject enemyPrefab;
        public TextAsset jsonFile;

        private void Start()
        {
            if (jsonFile == null || enemyPrefab == null)
            {
                Debug.LogError("JSON 파일 또는 프리팹이 없습니다!");
                return;
            }

            EnemyData enemyData = JsonUtility.FromJson<EnemyData>(jsonFile.text);

            GameObject newEnemy = Instantiate(enemyPrefab);
            Enemy enemyScript = newEnemy.GetComponent<Enemy>();

            if (enemyScript is not null)
            {
                enemyScript.Initialize(enemyData);
                enemyScript.PrintStatus();
            }
        }
    }
}