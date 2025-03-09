using System;
using UnityEngine;

namespace Design.Prototype.CsharpStyle
{
    [Serializable]
    public class CharacterData : ICloneable
    {
        public string name;
        public int health;
        public int attackPower;

        public CharacterData(string name, int health, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
        }

        public object Clone()
        {
            return new CharacterData(this.name, this.health, this.attackPower);
        }
    }
}
