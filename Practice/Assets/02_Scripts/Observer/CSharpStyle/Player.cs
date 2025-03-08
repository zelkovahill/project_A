using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace Observer.CSharpStyle
{
    public class Player : MonoBehaviour
    {
        public event Action<int> OnHealthChanged;
        // public UnityEvent<int> OnHealthChanged;

        private int _health = 100;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage(10);
            }
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
            OnHealthChanged?.Invoke(_health);
        }
    }
}
