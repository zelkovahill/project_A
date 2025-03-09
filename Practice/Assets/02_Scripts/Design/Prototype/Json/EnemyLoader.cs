using UnityEngine;

public class EnemyLoader : MonoBehaviour
{
    public TextAsset jsonFile;

    private void Start()
    {
        if (jsonFile is not null)
        {
            string json = jsonFile.text;
            EnemyData enemyData = JsonUtility.FromJson<EnemyData>(json);

            Debug.Log($"Name: {enemyData.name}");
            Debug.Log($"Basic Health: {enemyData.basicHealth}");
            Debug.Log($"Max Health: {enemyData.maxHealth}");
            Debug.Log($"Tolerance: {string.Join(", ", enemyData.tolerance)}");
            Debug.Log($"Weakness: {string.Join(", ", enemyData.weakness)}");
        }
        else
        {
            Debug.LogError("Json 파일이 없습니다.");
        }
    }
}
