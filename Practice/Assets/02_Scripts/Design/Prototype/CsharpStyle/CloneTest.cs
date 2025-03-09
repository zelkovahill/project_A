using UnityEngine;

namespace Design.Prototype.CsharpStyle
{
    public class CloneTest : MonoBehaviour
    {
        private void Start()
        {
            var characterData = new CharacterData("전사", 100, 10);
            var clone = (CharacterData)characterData.Clone();

            clone.name = "마법사";
            clone.health = 50;
            clone.attackPower = 20;

            Debug.Log($"characterData: {characterData.name}, {characterData.health}, {characterData.attackPower}");
            Debug.Log($"clone: {clone.name}, {clone.health}, {clone.attackPower}");
        }
    }
}