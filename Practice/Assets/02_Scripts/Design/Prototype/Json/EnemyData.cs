using System;
using UnityEngine;

[Serializable]
public class EnemyData
{
    public string name;
    public int basicHealth;
    public int maxHealth;
    public string[] tolerance;
    public string[] weakness;
}
