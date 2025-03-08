using System.Collections.Generic;
using UnityEngine;

namespace Observer.Interface
{
    public class Player : MonoBehaviour
    {
        private List<IHealthObserver> _observers = new List<IHealthObserver>();
        private int _health = 100;

        public void RegisterObserver(IHealthObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IHealthObserver observer)
        {
            _observers.Remove(observer);
        }

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
            _health = Mathf.Max(0, _health);

            foreach (var observer in _observers)
            {
                observer.OnHealthChanged(_health);
            }
        }
    }
}